using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyJobApplication
{
    public partial class DisplayJobActivityForm : Form
    {
        public string DataFile = string.Empty;

        public DisplayJobActivityForm()
        {
            InitializeComponent();
        }

        private void DisplayJobActivityForm_Load(object sender, EventArgs e)
        {
            if (DataFile == string.Empty)
            {
                MessageBox.Show("No Record is found in the system");
                return;
            }

            XDocument doc = XDocument.Load(DataFile);

            foreach (var dm in doc.Descendants("jobActivity"))
            {
                dateTimePickerCreatedOn.Value = DateTime.Parse(dm.Element("createdOn").Value);
                dateTimePickerModifiedOn.Value = DateTime.Parse(dm.Element("modifiedOn").Value);
                dateTimePickerAppliedOn.Value = DateTime.Parse(dm.Element("activityDate").Value);
                txtTitle.Text = dm.Element("title").Value;
                txtBody.Text = dm.Element("body").Value;
                txtRegarding.Text = dm.Element("regarding").Value;
                txtContact.Text = dm.Element("contact").Value;
                cmbType.SelectedItem = dm.Element("type").Value;
            }
        }
    }
}
