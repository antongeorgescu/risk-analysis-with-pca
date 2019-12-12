namespace R_MessageBroker
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.tbTimer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.Color.White;
            this.tbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInfo.Location = new System.Drawing.Point(12, 285);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(511, 80);
            this.tbInfo.TabIndex = 1;
            this.tbInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTimer
            // 
            this.tbTimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimer.Location = new System.Drawing.Point(383, 137);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.Size = new System.Drawing.Size(136, 23);
            this.tbTimer.TabIndex = 2;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 377);
            this.Controls.Add(this.tbTimer);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.Text = "Long Running Job";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SplashForm_OnFormClosing);
            this.Load += new System.EventHandler(this.SplashForm_OnLoad);
            this.VisibleChanged += new System.EventHandler(this.SplashForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.TextBox tbTimer;
    }
}