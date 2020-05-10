using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;

namespace SimpleXmlAutoUpdater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CurrentSha384TextBox.Text = GetSHA384("./SimpleXmlAutoUpdater.exe.config");
        }

        private static readonly XmlDocument XmlUpdateFileDoc = new XmlDocument();
        private static string XmlGetSingleNode(string nodelocation) => XmlUpdateFileDoc.DocumentElement.SelectSingleNode(nodelocation).InnerText;

        private void CheckForUpdates()
        {
            ServicePointManager.Expect100Continue = true;//win7 fix
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;//win7 fix
            using (WebClient client = new WebClient())
            {
                client.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
                XmlUpdateFileDoc.LoadXml(client.DownloadString("https://pastebin.com/raw/8HpBBdPd"));//using pastebin as github kinda broken for webclient
            }

            if (XmlGetSingleNode("/App/Sha384") != CurrentSha384TextBox.Text)
            {
                MessageBox.Show("Update found for App", "Update Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //simple code to download update
                /*using (WebClient WebC = new WebClient())
                {
                    var data = WebC.DownloadData(XmlGetSingleNode("/App/DownloadUrl"));
                    File.WriteAllBytes(@".\SimpleXmlAutoUpdater.exe", data);
                }*/
            }
            else
                MessageBox.Show("No Updates Found");
        }

        private static string GetSHA384(string filepath)
        {
            FileStream filestream = new FileStream(filepath, FileMode.Open)
            {
                Position = 0
            };

            var filehash = BitConverter.ToString(System.Security.Cryptography.SHA384.Create().ComputeHash(filestream)).Replace("-", string.Empty);

            filestream.Close();

            return filehash;
        }

        private void CheckforupdatesBTN_Click(object sender, EventArgs e) => CheckForUpdates();
    }
}
