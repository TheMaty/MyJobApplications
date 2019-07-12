namespace MyJobApplication
{
    partial class CompanyLookup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.dataGridViewCompany = new System.Windows.Forms.DataGridView();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(3, 18);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(67, 17);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "Company";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(82, 16);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(278, 22);
            this.txtBox.TabIndex = 1;
            this.txtBox.Tag = "star works";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(367, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.lblCompany);
            this.splitContainerMain.Panel1.Controls.Add(this.btnSearch);
            this.splitContainerMain.Panel1.Controls.Add(this.txtBox);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.dataGridViewCompany);
            this.splitContainerMain.Size = new System.Drawing.Size(446, 291);
            this.splitContainerMain.SplitterDistance = 51;
            this.splitContainerMain.TabIndex = 3;
            // 
            // dataGridViewCompany
            // 
            this.dataGridViewCompany.AllowUserToAddRows = false;
            this.dataGridViewCompany.AllowUserToDeleteRows = false;
            this.dataGridViewCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountName,
            this.URL});
            this.dataGridViewCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCompany.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCompany.Name = "dataGridViewCompany";
            this.dataGridViewCompany.ReadOnly = true;
            this.dataGridViewCompany.RowTemplate.Height = 24;
            this.dataGridViewCompany.Size = new System.Drawing.Size(446, 236);
            this.dataGridViewCompany.TabIndex = 0;
            // 
            // AccountName
            // 
            this.AccountName.HeaderText = "Company Name";
            this.AccountName.Name = "AccountName";
            this.AccountName.ReadOnly = true;
            this.AccountName.Width = 200;
            // 
            // URL
            // 
            this.URL.HeaderText = "Company Web Site";
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            this.URL.Width = 200;
            // 
            // CompanyLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerMain);
            this.Name = "CompanyLookup";
            this.Size = new System.Drawing.Size(446, 291);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.DataGridView dataGridViewCompany;
        private new System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
    }
}
