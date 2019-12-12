namespace R_MessageBroker
{
    partial class ChartMagnifier
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
            this.picChartMagnifier = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picChartMagnifier)).BeginInit();
            this.SuspendLayout();
            // 
            // picChartMagnifier
            // 
            this.picChartMagnifier.Location = new System.Drawing.Point(22, 12);
            this.picChartMagnifier.Name = "picChartMagnifier";
            this.picChartMagnifier.Size = new System.Drawing.Size(100, 50);
            this.picChartMagnifier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picChartMagnifier.TabIndex = 0;
            this.picChartMagnifier.TabStop = false;
            this.picChartMagnifier.SizeChanged += new System.EventHandler(this.picChartMagnifier_SizeChanged);
            this.picChartMagnifier.Click += new System.EventHandler(this.picChartMagnifier_Click);
            // 
            // ChartMagnifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(148, 85);
            this.Controls.Add(this.picChartMagnifier);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChartMagnifier";
            this.Text = "Chart Magnifier";
            ((System.ComponentModel.ISupportInitialize)(this.picChartMagnifier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picChartMagnifier;
    }
}