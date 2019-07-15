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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("My Job Applications", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // mainTreeView
            // 
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
            treeNode4.Name = "Activities";
            treeNode4.Text = "Activities";
            treeNode5.Name = "MyJobApplications";
            treeNode5.Text = "My Job Applications";
            this.mainTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.mainTreeView.Size = new System.Drawing.Size(259, 600);
            this.mainTreeView.TabIndex = 0;
            this.mainTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.mainTreeView_NodeMouseClick);
            // 
            // TreeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 600);
            this.ControlBox = false;
            this.Controls.Add(this.mainTreeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TreeViewForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "TreeViewForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView mainTreeView;
    }
}