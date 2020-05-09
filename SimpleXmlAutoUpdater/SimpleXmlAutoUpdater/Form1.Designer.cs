namespace SimpleXmlAutoUpdater
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckforupdatesBTN = new System.Windows.Forms.Button();
            this.CurrentSha384TextBox = new System.Windows.Forms.TextBox();
            this.CurrentSha384Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckforupdatesBTN
            // 
            this.CheckforupdatesBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckforupdatesBTN.Location = new System.Drawing.Point(279, 95);
            this.CheckforupdatesBTN.Name = "CheckforupdatesBTN";
            this.CheckforupdatesBTN.Size = new System.Drawing.Size(143, 39);
            this.CheckforupdatesBTN.TabIndex = 0;
            this.CheckforupdatesBTN.Text = "Check for Updates";
            this.CheckforupdatesBTN.UseVisualStyleBackColor = true;
            this.CheckforupdatesBTN.Click += new System.EventHandler(this.CheckforupdatesBTN_Click);
            // 
            // CurrentSha384TextBox
            // 
            this.CurrentSha384TextBox.Location = new System.Drawing.Point(28, 49);
            this.CurrentSha384TextBox.Name = "CurrentSha384TextBox";
            this.CurrentSha384TextBox.Size = new System.Drawing.Size(728, 20);
            this.CurrentSha384TextBox.TabIndex = 3;
            // 
            // CurrentSha384Label
            // 
            this.CurrentSha384Label.AutoSize = true;
            this.CurrentSha384Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentSha384Label.Location = new System.Drawing.Point(275, 9);
            this.CurrentSha384Label.Name = "CurrentSha384Label";
            this.CurrentSha384Label.Size = new System.Drawing.Size(141, 20);
            this.CurrentSha384Label.TabIndex = 4;
            this.CurrentSha384Label.Text = "Current Sha384:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 152);
            this.Controls.Add(this.CurrentSha384Label);
            this.Controls.Add(this.CurrentSha384TextBox);
            this.Controls.Add(this.CheckforupdatesBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SimpleXmlAutoUpdater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckforupdatesBTN;
        private System.Windows.Forms.TextBox CurrentSha384TextBox;
        private System.Windows.Forms.Label CurrentSha384Label;
    }
}

