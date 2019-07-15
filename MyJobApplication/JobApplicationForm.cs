using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyJobApplication
{
    public partial class JobApplicationForm : Form
    {
        public JobApplicationForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //generate XML
            jobApplication jb = new jobApplication();

            jb.createdOn = DateTime.Now;
            jb.modifiedOn = DateTime.Now;
            jb.applicationDate = DateTime.Now;
            jb.advertisement = txtBody.Text;
            jb.advertiser = txtContact.Text;

            // Read docx of my CV
            try
            {
                jb.AppliedCVBinary = File.ReadAllBytes(txtCV.Text);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error is occured", MessageBoxButtons.OK);
            }

            jb.company = txtCompany.Text;
            jb.title = txtTitle.Text;
            jb.url = txtURL.Text;

            DataStoreLayer ds = new DataStoreLayer();
            ds.InsertApplication(jb);

            MessageBox.Show("Record has been added successfully");
            ((MyJobApplications)this.Owner).RefreshListView();
            this.Close();
            
        }

        private void btnCV_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.AddExtension = true;
            openFileDialog.AutoUpgradeEnabled = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = false;
            openFileDialog.ShowHelp = true;
            openFileDialog.ShowReadOnly = false;
            openFileDialog.SupportMultiDottedExtensions = false;
            openFileDialog.Title = "Select CV which is used in the Job Application";
            openFileDialog.Filter = "Microsoft Office Word files (*.docx)|*.docx";



            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtCV.Text = openFileDialog.FileName;
            }

        }

        private void JobApplicationForm_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection dataCompany = new AutoCompleteStringCollection();
            foreach (string str in ((TreeViewForm)this.MdiParent.MdiChildren[0]).Companies)
            {
                dataCompany.Add(str);
            }
            txtCompany.AutoCompleteCustomSource = dataCompany;

            AutoCompleteStringCollection dataContact = new AutoCompleteStringCollection();
            foreach (string str in ((TreeViewForm)this.MdiParent.MdiChildren[0]).Contacts)
            {
                dataContact.Add(str);
            }
            txtContact.AutoCompleteCustomSource = dataContact;
        }
    }
}
