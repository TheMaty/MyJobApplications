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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Applications");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Companies");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Contacts");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Activities");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Regarding");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Contacts");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Activities", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("My Job Applications", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode7});
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // mainTreeView
            // 
            this.mainTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTreeView.Location = new System.Drawing.Point(0, 0);
            this.mainTreeView.Name = "mainTreeView";
            treeNode1.Name = "Applications";
            treeNode1.Text = "Applications";
            treeNode1.ToolTipText = "My dreams";
            treeNode2.Name = "Companies";
            treeNode2.Text = "Companies";
            treeNode3.Name = "Contacts";
            treeNode3.Text = "Contacts";
            treeNode3.ToolTipText = "People who i chat";
            treeNode4.Name = "Activities-Applications";
            treeNode4.Text = "Activities";
            treeNode5.Name = "Activities-Regarding";
            treeNode5.Text = "Regarding";
            treeNode6.Name = "Activities-Contacts";
            treeNode6.Text = "Contacts";
            treeNode7.Name = "Activities";
            treeNode7.Text = "Activities";
            treeNode8.Name = "MyJobApplications";
            treeNode8.Text = "My Job Applications";
            this.mainTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.mainTreeView.Size = new System.Drawing.Size(367, 600);
            this.mainTreeView.TabIndex = 0;
            this.mainTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.mainTreeView_NodeMouseClick);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView mainTreeView;
    }
}