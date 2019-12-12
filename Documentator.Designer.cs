namespace R_MessageBroker
{
    partial class Documentator
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
            this.picContent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picContent)).BeginInit();
            this.SuspendLayout();
            // 
            // picContent
            // 
            this.picContent.Location = new System.Drawing.Point(12, 12);
            this.picContent.Name = "picContent";
            this.picContent.Size = new System.Drawing.Size(841, 540);
            this.picContent.TabIndex = 0;
            this.picContent.TabStop = false;
            // 
            // Documentator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 564);
            this.Controls.Add(this.picContent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Documentator";
            this.Text = "Deep Thought Documentator";
            ((System.ComponentModel.ISupportInitialize)(this.picContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picContent;
    }
}