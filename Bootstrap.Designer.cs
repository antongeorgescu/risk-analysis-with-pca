namespace R_MessageBroker
{
    partial class Bootstrap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bootstrap));
            this.bnBaseAnalytics = new System.Windows.Forms.Button();
            this.bnBasePrediction = new System.Windows.Forms.Button();
            this.bnInstallRPkgs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.caHelpProvider = new System.Windows.Forms.HelpProvider();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bnBaseAnalytics
            // 
            this.bnBaseAnalytics.Location = new System.Drawing.Point(258, 23);
            this.bnBaseAnalytics.Name = "bnBaseAnalytics";
            this.bnBaseAnalytics.Size = new System.Drawing.Size(236, 45);
            this.bnBaseAnalytics.TabIndex = 0;
            this.bnBaseAnalytics.Text = "Run Baseline Analytics";
            this.bnBaseAnalytics.UseVisualStyleBackColor = true;
            this.bnBaseAnalytics.Click += new System.EventHandler(this.bnBaseAnalytics_Click);
            // 
            // bnBasePrediction
            // 
            this.bnBasePrediction.Location = new System.Drawing.Point(258, 86);
            this.bnBasePrediction.Name = "bnBasePrediction";
            this.bnBasePrediction.Size = new System.Drawing.Size(236, 45);
            this.bnBasePrediction.TabIndex = 1;
            this.bnBasePrediction.Text = "Run CA Prediction";
            this.bnBasePrediction.UseVisualStyleBackColor = true;
            this.bnBasePrediction.Click += new System.EventHandler(this.bnBasePrediction_Click);
            // 
            // bnInstallRPkgs
            // 
            this.bnInstallRPkgs.Location = new System.Drawing.Point(258, 146);
            this.bnInstallRPkgs.Name = "bnInstallRPkgs";
            this.bnInstallRPkgs.Size = new System.Drawing.Size(236, 45);
            this.bnInstallRPkgs.TabIndex = 2;
            this.bnInstallRPkgs.Text = "Install R Packages";
            this.bnInstallRPkgs.UseVisualStyleBackColor = true;
            this.bnInstallRPkgs.Click += new System.EventHandler(this.bnInstallRPkgs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // caHelpProvider
            // 
            this.caHelpProvider.HelpNamespace = "C:\\Users\\ag4488\\Documents\\Visual Studio 2017\\Projects\\Hackathon-2019\\HelpDocument" +
    "ation\\DeepThoughtHelp.chm";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(56, 211);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(409, 43);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "To get help at anytime while using the application press \"F1\" key on your keyboar" +
    "d. Then select the topic you are interested in.";
            // 
            // Bootstrap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 272);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bnInstallRPkgs);
            this.Controls.Add(this.bnBasePrediction);
            this.Controls.Add(this.bnBaseAnalytics);
            this.caHelpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bootstrap";
            this.caHelpProvider.SetShowHelp(this, true);
            this.Text = "DeepThought Bootstrap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnBaseAnalytics;
        private System.Windows.Forms.Button bnBasePrediction;
        private System.Windows.Forms.Button bnInstallRPkgs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.HelpProvider caHelpProvider;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}