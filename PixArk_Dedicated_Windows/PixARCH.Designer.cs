namespace PixArk_Dedicated_Windows
{
    partial class PixARCH
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
            this.bCreateSrv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCreateSrv
            // 
            this.bCreateSrv.Location = new System.Drawing.Point(360, 49);
            this.bCreateSrv.Name = "bCreateSrv";
            this.bCreateSrv.Size = new System.Drawing.Size(162, 23);
            this.bCreateSrv.TabIndex = 0;
            this.bCreateSrv.Text = "Create Server";
            this.bCreateSrv.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PixARCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 277);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bCreateSrv);
            this.Name = "PixARCH";
            this.Text = "PixARCH";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCreateSrv;
        private System.Windows.Forms.Button button1;
    }
}