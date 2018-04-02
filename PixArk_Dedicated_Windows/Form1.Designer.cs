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
            this.Instruction_01 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.srvGamePort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.srvQueryPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.srvRCONPort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.srvCubePort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.srvSessionName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.srvSeed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Folder and Finish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // Server_Path
            // 
            this.Server_Path.AutoSize = true;
            this.Server_Path.Location = new System.Drawing.Point(123, 345);
            this.Server_Path.Name = "Server_Path";
            this.Server_Path.Size = new System.Drawing.Size(0, 13);
            this.Server_Path.TabIndex = 1;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(9, 345);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(108, 13);
            this.PathLabel.TabIndex = 2;
            this.PathLabel.Text = "PIXARK Server Path:";
            this.PathLabel.Click += new System.EventHandler(this.PathLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "PIXARK Server Folder Name: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // srvdir
            // 
            this.srvdir.Location = new System.Drawing.Point(165, 56);
            this.srvdir.Name = "srvdir";
            this.srvdir.Size = new System.Drawing.Size(122, 20);
            this.srvdir.TabIndex = 1;
            this.srvdir.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.srvdir.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.srvdir_PreviewKeyDown);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(10, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // desktopSC
            // 
            this.desktopSC.AutoSize = true;
            this.desktopSC.Location = new System.Drawing.Point(13, 130);
            this.desktopSC.Name = "desktopSC";
            this.desktopSC.Size = new System.Drawing.Size(228, 17);
            this.desktopSC.TabIndex = 2;
            this.desktopSC.Text = "Create Desktop Shortcut for The Launcher";
            this.desktopSC.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(10, 429);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(264, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://developer.valvesoftware.com/wiki/SteamCMD";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 61);
            this.label2.TabIndex = 0;
            this.label2.Text = "SteamCMD is downloaded and launched when using this tool. The link below is to th" +
    "e official Valve Developer Community page that contains the Download for SteamCM" +
    "D used in this program.";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Instruction_01
            // 
            this.Instruction_01.AutoSize = true;
            this.Instruction_01.Location = new System.Drawing.Point(10, 27);
            this.Instruction_01.Name = "Instruction_01";
            this.Instruction_01.Size = new System.Drawing.Size(196, 13);
            this.Instruction_01.TabIndex = 11;
            this.Instruction_01.Text = "Enter a simple name for the server folder";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 40);
            this.label3.TabIndex = 15;
            this.label3.Text = "These are the 4 ports that you need to have forwarded on your router. These may b" +
    "e changed. DO NOT OVERLAP";
            // 
            // srvGamePort
            // 
            this.srvGamePort.Location = new System.Drawing.Point(168, 212);
            this.srvGamePort.Name = "srvGamePort";
            this.srvGamePort.Size = new System.Drawing.Size(119, 20);
            this.srvGamePort.TabIndex = 16;
            this.srvGamePort.Text = "27015";
            this.srvGamePort.TextChanged += new System.EventHandler(this.srvGamePort_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Game Port: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Query Port: ";
            // 
            // srvQueryPort
            // 
            this.srvQueryPort.Location = new System.Drawing.Point(168, 238);
            this.srvQueryPort.Name = "srvQueryPort";
            this.srvQueryPort.Size = new System.Drawing.Size(119, 20);
            this.srvQueryPort.TabIndex = 18;
            this.srvQueryPort.Text = "27016";
            this.srvQueryPort.TextChanged += new System.EventHandler(this.srvQueryPort_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "RCON Port: ";
            // 
            // srvRCONPort
            // 
            this.srvRCONPort.Location = new System.Drawing.Point(168, 264);
            this.srvRCONPort.Name = "srvRCONPort";
            this.srvRCONPort.Size = new System.Drawing.Size(119, 20);
            this.srvRCONPort.TabIndex = 20;
            this.srvRCONPort.Text = "27017";
            this.srvRCONPort.TextChanged += new System.EventHandler(this.srvRCONPort_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "cubeport: ";
            // 
            // srvCubePort
            // 
            this.srvCubePort.Location = new System.Drawing.Point(168, 290);
            this.srvCubePort.Name = "srvCubePort";
            this.srvCubePort.Size = new System.Drawing.Size(119, 20);
            this.srvCubePort.TabIndex = 22;
            this.srvCubePort.Text = "27018";
            this.srvCubePort.TextChanged += new System.EventHandler(this.srvCubePort_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Server Session Name:";
            // 
            // srvSessionName
            // 
            this.srvSessionName.Location = new System.Drawing.Point(165, 81);
            this.srvSessionName.Name = "srvSessionName";
            this.srvSessionName.Size = new System.Drawing.Size(122, 20);
            this.srvSessionName.TabIndex = 24;
            this.srvSessionName.Text = "JustAnotherServer";
            this.srvSessionName.TextChanged += new System.EventHandler(this.srvSessionName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Server Seed:";
            // 
            // srvSeed
            // 
            this.srvSeed.Location = new System.Drawing.Point(165, 107);
            this.srvSeed.Name = "srvSeed";
            this.srvSeed.Size = new System.Drawing.Size(122, 20);
            this.srvSeed.TabIndex = 26;
            this.srvSeed.Text = "123456";
            this.srvSeed.TextChanged += new System.EventHandler(this.srvSeed_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 481);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.srvSeed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.srvSessionName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.srvCubePort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.srvRCONPort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.srvQueryPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.srvGamePort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Instruction_01);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label Instruction_01;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox srvGamePort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox srvQueryPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox srvRCONPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox srvCubePort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox srvSessionName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox srvSeed;
    }
}

