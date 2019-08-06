namespace MyJobApplication
{
    partial class Activities
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
            this.listViewActivities = new System.Windows.Forms.ListView();
            this.activityDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.regarding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.body = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewActivities
            // 
            this.listViewActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.activityDate,
            this.title,
            this.regarding,
            this.contact,
            this.type,
            this.body});
            this.listViewActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewActivities.FullRowSelect = true;
            this.listViewActivities.HideSelection = false;
            this.listViewActivities.MultiSelect = false;
            this.listViewActivities.Location = new System.Drawing.Point(0, 0);
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.ShowGroups = false;
            this.listViewActivities.Size = new System.Drawing.Size(815, 647);
            this.listViewActivities.TabIndex = 0;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            this.listViewActivities.View = System.Windows.Forms.View.Details;
            this.listViewActivities.DoubleClick += new System.EventHandler(this.ListViewActivities_DoubleClick);

            // 
            // activityDate
            // 
            this.activityDate.Text = "Activity Date";
            this.activityDate.Width = 100;
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.Width = 200;
            // 
            // regarding
            // 
            this.regarding.Text = "Regarding";
            this.regarding.Width = 100;
            // 
            // contact
            // 
            this.contact.Text = "Contact";
            this.contact.Width = 100;
            // 
            // type
            // 
            this.type.Text = "Type";
            this.type.Width = 100;
            // 
            // body
            // 
            this.body.Text = "Body";
            this.body.Width = 180;
            // 
            // Activities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(815, 647);
            this.ControlBox = false;
            this.Controls.Add(this.listViewActivities);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Activities";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Activities";
            this.Load += new System.EventHandler(this.Activities_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.ColumnHeader activityDate;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader regarding;
        private System.Windows.Forms.ColumnHeader contact;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader body;
    }
}