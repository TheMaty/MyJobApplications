﻿namespace MyJobApplication
{
    partial class DisplayApplicationForm
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
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dateTimePickerModifiedOn = new System.Windows.Forms.DateTimePicker();
            this.lblModifiedOn = new System.Windows.Forms.Label();
            this.dateTimePickerCreatedOn = new System.Windows.Forms.DateTimePicker();
            this.lblCreatedOn = new System.Windows.Forms.Label();
            this.lblAppliedOn = new System.Windows.Forms.Label();
            this.dateTimePickerAppliedOn = new System.Windows.Forms.DateTimePicker();
            this.officeViewer1 = new Spire.OfficeViewer.Forms.OfficeViewer();
            this.txtBody = new System.Windows.Forms.RichTextBox();
            this.lblClosedOn = new System.Windows.Forms.Label();
            this.dateTimePickerClosedOn = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtCompany
            // 
            this.txtCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCompany.Location = new System.Drawing.Point(136, 170);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.ReadOnly = true;
            this.txtCompany.Size = new System.Drawing.Size(628, 22);
            this.txtCompany.TabIndex = 101;
            // 
            // txtContact
            // 
            this.txtContact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtContact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtContact.Location = new System.Drawing.Point(136, 213);
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.Size = new System.Drawing.Size(628, 22);
            this.txtContact.TabIndex = 102;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(34, 218);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(56, 17);
            this.lblContact.TabIndex = 117;
            this.lblContact.Text = "Contact";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(34, 175);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(67, 17);
            this.lblCompany.TabIndex = 116;
            this.lblCompany.Text = "Company";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(136, 260);
            this.txtURL.Name = "txtURL";
            this.txtURL.ReadOnly = true;
            this.txtURL.Size = new System.Drawing.Size(628, 22);
            this.txtURL.TabIndex = 103;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(38, 260);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(36, 17);
            this.lblURL.TabIndex = 113;
            this.lblURL.Text = "URL";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(34, 388);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(40, 17);
            this.lblDetails.TabIndex = 112;
            this.lblDetails.Text = "Body";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(136, 300);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTitle.Size = new System.Drawing.Size(628, 72);
            this.txtTitle.TabIndex = 104;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(34, 300);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 17);
            this.lblTitle.TabIndex = 111;
            this.lblTitle.Text = "Title ";
            // 
            // dateTimePickerModifiedOn
            // 
            this.dateTimePickerModifiedOn.Enabled = false;
            this.dateTimePickerModifiedOn.Location = new System.Drawing.Point(136, 100);
            this.dateTimePickerModifiedOn.Name = "dateTimePickerModifiedOn";
            this.dateTimePickerModifiedOn.Size = new System.Drawing.Size(628, 22);
            this.dateTimePickerModifiedOn.TabIndex = 110;
            // 
            // lblModifiedOn
            // 
            this.lblModifiedOn.AutoSize = true;
            this.lblModifiedOn.Location = new System.Drawing.Point(34, 105);
            this.lblModifiedOn.Name = "lblModifiedOn";
            this.lblModifiedOn.Size = new System.Drawing.Size(84, 17);
            this.lblModifiedOn.TabIndex = 109;
            this.lblModifiedOn.Text = "Modified On";
            // 
            // dateTimePickerCreatedOn
            // 
            this.dateTimePickerCreatedOn.Enabled = false;
            this.dateTimePickerCreatedOn.Location = new System.Drawing.Point(136, 57);
            this.dateTimePickerCreatedOn.Name = "dateTimePickerCreatedOn";
            this.dateTimePickerCreatedOn.Size = new System.Drawing.Size(628, 22);
            this.dateTimePickerCreatedOn.TabIndex = 108;
            // 
            // lblCreatedOn
            // 
            this.lblCreatedOn.AutoSize = true;
            this.lblCreatedOn.Location = new System.Drawing.Point(34, 62);
            this.lblCreatedOn.Name = "lblCreatedOn";
            this.lblCreatedOn.Size = new System.Drawing.Size(81, 17);
            this.lblCreatedOn.TabIndex = 107;
            this.lblCreatedOn.Text = "Created On";
            // 
            // lblAppliedOn
            // 
            this.lblAppliedOn.AutoSize = true;
            this.lblAppliedOn.Location = new System.Drawing.Point(34, 19);
            this.lblAppliedOn.Name = "lblAppliedOn";
            this.lblAppliedOn.Size = new System.Drawing.Size(78, 17);
            this.lblAppliedOn.TabIndex = 118;
            this.lblAppliedOn.Text = "Applied On";
            // 
            // dateTimePickerAppliedOn
            // 
            this.dateTimePickerAppliedOn.Enabled = false;
            this.dateTimePickerAppliedOn.Location = new System.Drawing.Point(136, 14);
            this.dateTimePickerAppliedOn.Name = "dateTimePickerAppliedOn";
            this.dateTimePickerAppliedOn.Size = new System.Drawing.Size(628, 22);
            this.dateTimePickerAppliedOn.TabIndex = 119;
            // 
            // officeViewer1
            // 
            this.officeViewer1.IsToolBarVisible = true;
            this.officeViewer1.Location = new System.Drawing.Point(799, 13);
            this.officeViewer1.Name = "officeViewer1";
            this.officeViewer1.Size = new System.Drawing.Size(1089, 780);
            this.officeViewer1.TabIndex = 120;
            this.officeViewer1.Text = "officeViewer1";
            this.officeViewer1.DocumentOpened += new Spire.OfficeViewer.Forms.DocumentOpenedEventHandler(this.OfficeViewer1_DocumentOpened);
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(136, 388);
            this.txtBody.Name = "txtBody";
            this.txtBody.ReadOnly = true;
            this.txtBody.Size = new System.Drawing.Size(628, 405);
            this.txtBody.TabIndex = 121;
            this.txtBody.Text = "";
            // 
            // lblClosedOn
            // 
            this.lblClosedOn.AutoSize = true;
            this.lblClosedOn.Location = new System.Drawing.Point(34, 138);
            this.lblClosedOn.Name = "lblClosedOn";
            this.lblClosedOn.Size = new System.Drawing.Size(74, 17);
            this.lblClosedOn.TabIndex = 122;
            this.lblClosedOn.Text = "Closed On";
            // 
            // dateTimePickerClosedOn
            // 
            this.dateTimePickerClosedOn.Enabled = false;
            this.dateTimePickerClosedOn.Location = new System.Drawing.Point(136, 136);
            this.dateTimePickerClosedOn.Name = "dateTimePickerClosedOn";
            this.dateTimePickerClosedOn.Size = new System.Drawing.Size(628, 22);
            this.dateTimePickerClosedOn.TabIndex = 123;
            // 
            // DisplayApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1900, 805);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePickerClosedOn);
            this.Controls.Add(this.lblClosedOn);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.officeViewer1);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dateTimePickerModifiedOn);
            this.Controls.Add(this.lblModifiedOn);
            this.Controls.Add(this.dateTimePickerCreatedOn);
            this.Controls.Add(this.lblCreatedOn);
            this.Controls.Add(this.lblAppliedOn);
            this.Controls.Add(this.dateTimePickerAppliedOn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayApplicationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Display Application Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplayApplicationForm_FormClosed);
            this.Load += new System.EventHandler(this.DisplayApplicationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dateTimePickerModifiedOn;
        private System.Windows.Forms.Label lblModifiedOn;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreatedOn;
        private System.Windows.Forms.Label lblCreatedOn;
        private System.Windows.Forms.Label lblAppliedOn;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppliedOn;
        private Spire.OfficeViewer.Forms.OfficeViewer officeViewer1;
        private System.Windows.Forms.RichTextBox txtBody;
        private System.Windows.Forms.Label lblClosedOn;
        private System.Windows.Forms.DateTimePicker dateTimePickerClosedOn;
    }
}