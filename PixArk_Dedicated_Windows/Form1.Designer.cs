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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Instruction_01 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(150, 281);
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
            this.Server_Path.Location = new System.Drawing.Point(123, 253);
            this.Server_Path.Name = "Server_Path";
            this.Server_Path.Size = new System.Drawing.Size(0, 13);
            this.Server_Path.TabIndex = 1;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(9, 253);
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
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "PIXARK Server Folder: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // srvdir
            // 
            this.srvdir.Location = new System.Drawing.Point(151, 56);
            this.srvdir.Name = "srvdir";
            this.srvdir.Size = new System.Drawing.Size(122, 20);
            this.srvdir.TabIndex = 1;
            this.srvdir.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.srvdir.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.srvdir_PreviewKeyDown);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(13, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // desktopSC
            // 
            this.desktopSC.AutoSize = true;
            this.desktopSC.Location = new System.Drawing.Point(13, 84);
            this.desktopSC.Name = "desktopSC";
            this.desktopSC.Size = new System.Drawing.Size(228, 17);
            this.desktopSC.TabIndex = 2;
            this.desktopSC.Text = "Create Desktop Shortcut for The Launcher";
            this.desktopSC.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 417);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(264, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://developer.valvesoftware.com/wiki/SteamCMD";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 61);
            this.label2.TabIndex = 0;
            this.label2.Text = "SteamCMD is downloaded and launched when using this tool. The link below is to th" +
    "e official Valve Developer Community page that contains the Download for SteamCM" +
    "D used in this program.";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 107);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Instruction_01
            // 
            this.Instruction_01.AutoSize = true;
            this.Instruction_01.Location = new System.Drawing.Point(10, 27);
            this.Instruction_01.Name = "Instruction_01";
            this.Instruction_01.Size = new System.Drawing.Size(213, 13);
            this.Instruction_01.TabIndex = 11;
            this.Instruction_01.Text = "Enter a simple name for the server directory.";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 181);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(188, 181);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(261, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Next";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 40);
            this.label3.TabIndex = 15;
            this.label3.Text = "Choose Simple or Advanced Server Parameters. Advanced will allow you to key in se" +
    "veral server settings.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 542);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Instruction_01);
            this.Controls.Add(this.checkBox1);
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label Instruction_01;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
    }
}

