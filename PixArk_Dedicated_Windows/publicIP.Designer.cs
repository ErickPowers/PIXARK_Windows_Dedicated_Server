namespace PixArk_Dedicated_Windows
{
    partial class publicIP
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
            this.IPINFO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IPINFO
            // 
            this.IPINFO.AutoSize = true;
            this.IPINFO.Location = new System.Drawing.Point(265, 120);
            this.IPINFO.Name = "IPINFO";
            this.IPINFO.Size = new System.Drawing.Size(72, 13);
            this.IPINFO.TabIndex = 0;
            this.IPINFO.Text = "ip_fetch_error";
            // 
            // publicIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 319);
            this.Controls.Add(this.IPINFO);
            this.Name = "publicIP";
            this.Text = "publicIP";
            this.Load += new System.EventHandler(this.publicIP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IPINFO;
    }
}