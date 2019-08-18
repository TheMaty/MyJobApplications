namespace MyJobApplication
{
    partial class TreeViewForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Open");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Close");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Applications", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Companies");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Contacts");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Activities");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Regarding");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Contacts");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("FollowUps");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Activities", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("My Job Applications", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode10});
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.applyForAJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addActivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeJobApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopFollowUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTreeView
            // 
            this.mainTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTreeView.ContextMenuStrip = this.contextMenuStrip1;
            this.mainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTreeView.Location = new System.Drawing.Point(0, 0);
            this.mainTreeView.Name = "mainTreeView";
            treeNode1.Name = "__Open";
            treeNode1.Text = "Open";
            treeNode2.Name = "__Close";
            treeNode2.Text = "Close";
            treeNode3.Name = "__Applications";
            treeNode3.Text = "Applications";
            treeNode3.ToolTipText = "My dreams";
            treeNode4.Name = "__Companies";
            treeNode4.Text = "Companies";
            treeNode5.Name = "__Contacts";
            treeNode5.Text = "Contacts";
            treeNode5.ToolTipText = "People who i chat";
            treeNode6.Name = "__Activities-Applications";
            treeNode6.Text = "Activities";
            treeNode7.Name = "__Activities-Regarding";
            treeNode7.Text = "Regarding";
            treeNode8.Name = "__Activities-Contacts";
            treeNode8.Text = "Contacts";
            treeNode9.Name = "__FollowUps";
            treeNode9.Text = "FollowUps";
            treeNode10.Name = "__Activities";
            treeNode10.Text = "Activities";
            treeNode11.Name = "__MyJobApplications";
            treeNode11.Text = "My Job Applications";
            this.mainTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.mainTreeView.Size = new System.Drawing.Size(367, 600);
            this.mainTreeView.TabIndex = 0;
            this.mainTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.mainTreeView_NodeMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applyForAJobToolStripMenuItem,
            this.addActivityToolStripMenuItem,
            this.closeJobApplicationToolStripMenuItem,
            this.stopFollowUpToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(223, 100);
            // 
            // applyForAJobToolStripMenuItem
            // 
            this.applyForAJobToolStripMenuItem.Name = "applyForAJobToolStripMenuItem";
            this.applyForAJobToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.applyForAJobToolStripMenuItem.Text = "Apply for a Job";
            this.applyForAJobToolStripMenuItem.Click += new System.EventHandler(this.ApplyForAJobToolStripMenuItem_Click);
            // 
            // addActivityToolStripMenuItem
            // 
            this.addActivityToolStripMenuItem.Name = "addActivityToolStripMenuItem";
            this.addActivityToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.addActivityToolStripMenuItem.Text = "Add Activity";
            this.addActivityToolStripMenuItem.Click += new System.EventHandler(this.AddActivityToolStripMenuItem_Click);
            // 
            // closeJobApplicationToolStripMenuItem
            // 
            this.closeJobApplicationToolStripMenuItem.Name = "closeJobApplicationToolStripMenuItem";
            this.closeJobApplicationToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.closeJobApplicationToolStripMenuItem.Text = "Close Job Application";
            this.closeJobApplicationToolStripMenuItem.Click += new System.EventHandler(this.CloseJobApplicationToolStripMenuItem_Click);
            // 
            // stopFollowUpToolStripMenuItem
            // 
            this.stopFollowUpToolStripMenuItem.Name = "stopFollowUpToolStripMenuItem";
            this.stopFollowUpToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.stopFollowUpToolStripMenuItem.Text = "Stop Follow Up";
            this.stopFollowUpToolStripMenuItem.Click += new System.EventHandler(this.StopFollowUpToolStripMenuItem_Click);
            // 
            // TreeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(367, 600);
            this.ControlBox = false;
            this.Controls.Add(this.mainTreeView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TreeViewForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Tree View";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView mainTreeView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applyForAJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addActivityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeJobApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopFollowUpToolStripMenuItem;
    }
}