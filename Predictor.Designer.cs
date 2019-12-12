namespace R_MessageBroker
{
    partial class Predictor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Predictor));
            this.splitContent = new System.Windows.Forms.SplitContainer();
            this.bnSaveCAAnalysis = new System.Windows.Forms.Button();
            this.bnExecute = new System.Windows.Forms.Button();
            this.cbActions = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bnCalculateScore = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstRowsCols = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbResults = new System.Windows.Forms.RichTextBox();
            this.lvPics = new System.Windows.Forms.ListView();
            this.imgBucket = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContent)).BeginInit();
            this.splitContent.Panel1.SuspendLayout();
            this.splitContent.Panel2.SuspendLayout();
            this.splitContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContent
            // 
            this.splitContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContent.Location = new System.Drawing.Point(0, 0);
            this.splitContent.Name = "splitContent";
            this.splitContent.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContent.Panel1
            // 
            this.splitContent.Panel1.Controls.Add(this.bnSaveCAAnalysis);
            this.splitContent.Panel1.Controls.Add(this.bnExecute);
            this.splitContent.Panel1.Controls.Add(this.cbActions);
            this.splitContent.Panel1.Controls.Add(this.label3);
            // 
            // splitContent.Panel2
            // 
            this.splitContent.Panel2.Controls.Add(this.label6);
            this.splitContent.Panel2.Controls.Add(this.tbScore);
            this.splitContent.Panel2.Controls.Add(this.label5);
            this.splitContent.Panel2.Controls.Add(this.bnCalculateScore);
            this.splitContent.Panel2.Controls.Add(this.label4);
            this.splitContent.Panel2.Controls.Add(this.lstRowsCols);
            this.splitContent.Panel2.Controls.Add(this.label2);
            this.splitContent.Panel2.Controls.Add(this.label1);
            this.splitContent.Panel2.Controls.Add(this.tbResults);
            this.splitContent.Panel2.Controls.Add(this.lvPics);
            this.splitContent.Size = new System.Drawing.Size(1233, 686);
            this.splitContent.SplitterDistance = 61;
            this.splitContent.TabIndex = 2;
            // 
            // bnSaveCAAnalysis
            // 
            this.bnSaveCAAnalysis.Location = new System.Drawing.Point(674, 20);
            this.bnSaveCAAnalysis.Name = "bnSaveCAAnalysis";
            this.bnSaveCAAnalysis.Size = new System.Drawing.Size(150, 33);
            this.bnSaveCAAnalysis.TabIndex = 3;
            this.bnSaveCAAnalysis.Text = "Save CA Prediction";
            this.bnSaveCAAnalysis.UseVisualStyleBackColor = true;
            this.bnSaveCAAnalysis.Click += new System.EventHandler(this.bnSaveCAAnalysis_Click);
            // 
            // bnExecute
            // 
            this.bnExecute.Location = new System.Drawing.Point(514, 18);
            this.bnExecute.Name = "bnExecute";
            this.bnExecute.Size = new System.Drawing.Size(154, 35);
            this.bnExecute.TabIndex = 2;
            this.bnExecute.Text = "Execute";
            this.bnExecute.UseVisualStyleBackColor = true;
            this.bnExecute.Click += new System.EventHandler(this.bnExecute_Click);
            // 
            // cbActions
            // 
            this.cbActions.FormattingEnabled = true;
            this.cbActions.Location = new System.Drawing.Point(192, 23);
            this.cbActions.Name = "cbActions";
            this.cbActions.Size = new System.Drawing.Size(303, 24);
            this.cbActions.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Analysis Task / Action:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1027, 583);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "%";
            // 
            // tbScore
            // 
            this.tbScore.Location = new System.Drawing.Point(934, 580);
            this.tbScore.Name = "tbScore";
            this.tbScore.ReadOnly = true;
            this.tbScore.Size = new System.Drawing.Size(87, 22);
            this.tbScore.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(879, 583);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Score:";
            // 
            // bnCalculateScore
            // 
            this.bnCalculateScore.Location = new System.Drawing.Point(1076, 574);
            this.bnCalculateScore.Name = "bnCalculateScore";
            this.bnCalculateScore.Size = new System.Drawing.Size(134, 35);
            this.bnCalculateScore.TabIndex = 7;
            this.bnCalculateScore.Text = "Predicted Score";
            this.bnCalculateScore.UseVisualStyleBackColor = true;
            this.bnCalculateScore.Click += new System.EventHandler(this.bnCalculateScore_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(879, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Profile Attributes";
            // 
            // lstRowsCols
            // 
            this.lstRowsCols.FormattingEnabled = true;
            this.lstRowsCols.ItemHeight = 16;
            this.lstRowsCols.Location = new System.Drawing.Point(882, 40);
            this.lstRowsCols.Name = "lstRowsCols";
            this.lstRowsCols.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstRowsCols.Size = new System.Drawing.Size(328, 516);
            this.lstRowsCols.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Basic Prediction Analysis Results...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "List of Charts generated...";
            // 
            // tbResults
            // 
            this.tbResults.Location = new System.Drawing.Point(342, 40);
            this.tbResults.Name = "tbResults";
            this.tbResults.Size = new System.Drawing.Size(524, 569);
            this.tbResults.TabIndex = 2;
            this.tbResults.Text = "";
            // 
            // lvPics
            // 
            this.lvPics.LargeImageList = this.imgBucket;
            this.lvPics.Location = new System.Drawing.Point(12, 40);
            this.lvPics.MultiSelect = false;
            this.lvPics.Name = "lvPics";
            this.lvPics.ShowItemToolTips = true;
            this.lvPics.Size = new System.Drawing.Size(312, 569);
            this.lvPics.SmallImageList = this.imgBucket;
            this.lvPics.StateImageList = this.imgBucket;
            this.lvPics.TabIndex = 0;
            this.lvPics.UseCompatibleStateImageBehavior = false;
            this.lvPics.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvPics_ItemSelectionChanged);
            this.lvPics.Click += new System.EventHandler(this.lvPics_Click);
            // 
            // imgBucket
            // 
            this.imgBucket.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgBucket.ImageStream")));
            this.imgBucket.TransparentColor = System.Drawing.Color.Transparent;
            this.imgBucket.Images.SetKeyName(0, "chart_logo.png");
            // 
            // Predictor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 686);
            this.Controls.Add(this.splitContent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Predictor";
            this.Text = "Dashboard";
            this.splitContent.Panel1.ResumeLayout(false);
            this.splitContent.Panel1.PerformLayout();
            this.splitContent.Panel2.ResumeLayout(false);
            this.splitContent.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContent)).EndInit();
            this.splitContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContent;
        public System.Windows.Forms.RichTextBox tbResults;
        private System.Windows.Forms.ListView lvPics;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnExecute;
        private System.Windows.Forms.ComboBox cbActions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imgBucket;
        private System.Windows.Forms.Button bnSaveCAAnalysis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstRowsCols;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bnCalculateScore;
    }
}