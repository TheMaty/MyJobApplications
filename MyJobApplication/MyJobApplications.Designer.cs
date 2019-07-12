namespace MyJobApplication
{
    partial class JobApplicationForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("My Applications");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Companies");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Company Contacts");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("My Job Applications", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.listViewApplications = new System.Windows.Forms.ListView();
            this.AppliedOn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Company = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Advertiser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.URL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Advertisement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.mainTreeView);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.listViewApplications);
            this.mainSplitContainer.Size = new System.Drawing.Size(1385, 683);
            this.mainSplitContainer.SplitterDistance = 190;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // mainTreeView
            // 
            this.mainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTreeView.Location = new System.Drawing.Point(0, 0);
            this.mainTreeView.Name = "mainTreeView";
            treeNode1.Name = "MyApplications";
            treeNode1.Text = "My Applications";
            treeNode2.Name = "Companies";
            treeNode2.Text = "Companies";
            treeNode3.Name = "CompanyContacts";
            treeNode3.Text = "Company Contacts";
            treeNode4.Name = "MyJobApplications";
            treeNode4.Text = "My Job Applications";
            this.mainTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.mainTreeView.Size = new System.Drawing.Size(190, 683);
            this.mainTreeView.TabIndex = 0;
            this.mainTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.mainTreeView_NodeMouseClick);
            // 
            // listViewApplications
            // 
            this.listViewApplications.AutoArrange = false;
            this.listViewApplications.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AppliedOn,
            this.Company,
            this.Advertiser,
            this.Title,
            this.URL,
            this.Advertisement,
            this.CV});
            this.listViewApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewApplications.FullRowSelect = true;
            this.listViewApplications.HideSelection = false;
            this.listViewApplications.Location = new System.Drawing.Point(0, 0);
            this.listViewApplications.MultiSelect = false;
            this.listViewApplications.Name = "listViewApplications";
            this.listViewApplications.ShowGroups = false;
            this.listViewApplications.Size = new System.Drawing.Size(1191, 683);
            this.listViewApplications.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewApplications.TabIndex = 0;
            this.listViewApplications.UseCompatibleStateImageBehavior = false;
            this.listViewApplications.View = System.Windows.Forms.View.Details;
            this.listViewApplications.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // AppliedOn
            // 
            this.AppliedOn.Text = "Applied On";
            this.AppliedOn.Width = 100;
            // 
            // Company
            // 
            this.Company.Text = "Company";
            this.Company.Width = 100;
            // 
            // Advertiser
            // 
            this.Advertiser.Text = "Advertiser";
            this.Advertiser.Width = 100;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 100;
            // 
            // URL
            // 
            this.URL.Text = "URL";
            this.URL.Width = 100;
            // 
            // Advertisement
            // 
            this.Advertisement.Text = "Advertisement";
            this.Advertisement.Width = 100;
            // 
            // CV
            // 
            this.CV.Text = "CV";
            this.CV.Width = 100;
            // 
            // JobApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 683);
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "JobApplicationForm";
            this.Text = "Job Applications";
            this.Load += new System.EventHandler(this.JobApplicationForm_Load);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.TreeView mainTreeView;
        private System.Windows.Forms.ListView listViewApplications;
        private System.Windows.Forms.ColumnHeader Company;
        private System.Windows.Forms.ColumnHeader Advertiser;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader URL;
        private System.Windows.Forms.ColumnHeader CV;
        private System.Windows.Forms.ColumnHeader Advertisement;
        private System.Windows.Forms.ColumnHeader AppliedOn;
    }
}

