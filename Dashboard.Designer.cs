namespace R_MessageBroker
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.splitContent = new System.Windows.Forms.SplitContainer();
            this.bnSaveCAAnalysis = new System.Windows.Forms.Button();
            this.bnExecute = new System.Windows.Forms.Button();
            this.cbActions = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.bnSaveCAAnalysis.Text = "Save CA Analysis";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dimensional Reduction Analysis Results...";
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
            this.tbResults.Size = new System.Drawing.Size(879, 569);
            this.tbResults.TabIndex = 2;
            this.tbResults.Text = "";
            // 
            // lvPics
            // 
            this.lvPics.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvPics.AllowColumnReorder = true;
            this.lvPics.GridLines = true;
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
            this.lvPics.View = System.Windows.Forms.View.SmallIcon;
            this.lvPics.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvPics_ItemSelectionChanged);
            this.lvPics.Click += new System.EventHandler(this.lvPics_Click);
            // 
            // imgBucket
            // 
            this.imgBucket.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgBucket.ImageStream")));
            this.imgBucket.TransparentColor = System.Drawing.Color.Transparent;
            this.imgBucket.Images.SetKeyName(0, "chart_logo.png");
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 686);
            this.Controls.Add(this.splitContent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
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
    }
}