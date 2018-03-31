namespace PixArk_Dedicated_Windows
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
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Server_Path = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.srvdir = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.desktopSC = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(153, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Server Path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // Server_Path
            // 
            this.Server_Path.AutoSize = true;
            this.Server_Path.Location = new System.Drawing.Point(126, 66);
            this.Server_Path.Name = "Server_Path";
            this.Server_Path.Size = new System.Drawing.Size(0, 13);
            this.Server_Path.TabIndex = 1;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(12, 66);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(108, 13);
            this.PathLabel.TabIndex = 2;
            this.PathLabel.Text = "PIXARK Server Path:";
            this.PathLabel.Click += new System.EventHandler(this.PathLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "PIXARK Server Folder: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // srvdir
            // 
            this.srvdir.Location = new System.Drawing.Point(153, 6);
            this.srvdir.Name = "srvdir";
            this.srvdir.Size = new System.Drawing.Size(122, 20);
            this.srvdir.TabIndex = 6;
            this.srvdir.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.srvdir.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.srvdir_PreviewKeyDown);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(12, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(587, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // desktopSC
            // 
            this.desktopSC.AutoSize = true;
            this.desktopSC.Location = new System.Drawing.Point(15, 34);
            this.desktopSC.Name = "desktopSC";
            this.desktopSC.Size = new System.Drawing.Size(234, 17);
            this.desktopSC.TabIndex = 8;
            this.desktopSC.Text = "Create Desktop Shortcut for The Launcher?";
            this.desktopSC.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 166);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(264, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://developer.valvesoftware.com/wiki/SteamCMD";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(587, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "SteamCMD is downloaded and launched when using this tool. The link below is to th" +
    "e official Valve Developer Community page that contains the Download for SteamCM" +
    "D.";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 218);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.desktopSC);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.srvdir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.Server_Path);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "PIXARK Dedicated Server Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label Server_Path;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox srvdir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox desktopSC;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
    }
}

