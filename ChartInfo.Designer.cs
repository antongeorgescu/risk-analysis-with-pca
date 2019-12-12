namespace R_MessageBroker
{
    partial class ChartInfo
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
            this.rbChartInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rbChartInfo
            // 
            this.rbChartInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rbChartInfo.Location = new System.Drawing.Point(21, 17);
            this.rbChartInfo.Name = "rbChartInfo";
            this.rbChartInfo.Size = new System.Drawing.Size(739, 426);
            this.rbChartInfo.TabIndex = 0;
            this.rbChartInfo.Text = "";
            // 
            // ChartInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 461);
            this.Controls.Add(this.rbChartInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChartInfo";
            this.Text = "ChartInfo";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox rbChartInfo;
    }
}