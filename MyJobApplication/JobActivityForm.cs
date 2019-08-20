using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyJobApplication
{
    public partial class JobActivityForm : Form
    {
        public JobActivityForm()
        {
            InitializeComponent();
        }

        public JobActivityForm(jobApplication followUpApplication)
        {
            InitializeComponent();
            txtRegarding.Text = followUpApplication.title;
            cmbType.SelectedItem = "Follow Up";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedItem == null)
            {
                MessageBox.Show("Please select Activity Type from the item list under type field", "Error occured", MessageBoxButtons.OK);
                return;
            }

            //generate XML
            jobActivity ja = new jobActivity();

            ja.activityDate = dateTimePickerAppliedOn.Value;
            ja.modifiedOn = DateTime.Now;
            ja.createdOn = DateTime.Now;
            ja.body = txtBody.Text;
            ja.contact = txtContact.Text;
            ja.regarding = txtRegarding.Text;
            ja.title = txtTitle.Text;
            ja.type = cmbType.SelectedItem.ToString();

            DataStoreLayer ds = new DataStoreLayer();
            ds.InsertActivity(ja);

            MessageBox.Show("Record has been added successfully");

            if (this.MdiParent.MdiChildren.Length > 0 && this.MdiParent.MdiChildren[0] is TreeViewForm)
                ((TreeViewForm)this.MdiParent.MdiChildren[0]).drawTree();

            this.Close();
        }

        private void JobActivityForm_Load(object sender, EventArgs e)
        {
            //read activity type from AppConfig
            string[] actTypes = ConfigurationManager.AppSettings["ActivityType"].Split(',');

            //set activity type combobox
            foreach (string str in actTypes)
                cmbType.Items.Add(str);
            
            AutoCompleteStringCollection dataRegarding = new AutoCompleteStringCollection();
            foreach (string str in ((TreeViewForm)this.MdiParent.MdiChildren[0]).Companies)
            {
                dataRegarding.Add(str);
            }
            foreach (string str in ((TreeViewForm)this.MdiParent.MdiChildren[0]).Contacts)
            {
                dataRegarding.Add(str);
            }
            foreach (string str in ((TreeViewForm)this.MdiParent.MdiChildren[0]).Applications)
            {
                dataRegarding.Add(str);
            }
            txtRegarding.AutoCompleteCustomSource = dataRegarding;

            AutoCompleteStringCollection dataContact = new AutoCompleteStringCollection();
            foreach (string str in ((TreeViewForm)this.MdiParent.MdiChildren[0]).Contacts)
            {
                dataContact.Add(str);
            }
            txtContact.AutoCompleteCustomSource = dataContact;
        }
    }
}
