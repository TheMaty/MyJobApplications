namespace MyJobApplication
{
    partial class Applications
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
            this.listViewApplications = new System.Windows.Forms.ListView();
            this.AppliedOn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Company = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Advertiser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.URL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Advertisement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            this.listViewApplications.Size = new System.Drawing.Size(815, 647);
            this.listViewApplications.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewApplications.TabIndex = 0;
            this.listViewApplications.UseCompatibleStateImageBehavior = false;
            this.listViewApplications.View = System.Windows.Forms.View.Details;
            this.listViewApplications.DoubleClick += new System.EventHandler(this.listViewApplications_DoubleClick);
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
            // Applications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 647);
            this.ControlBox = false;
            this.Controls.Add(this.listViewApplications);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Applications";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Applications";
            this.Load += new System.EventHandler(this.ApplicationsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

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