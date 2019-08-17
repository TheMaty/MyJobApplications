using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyJobApplication
{
    public partial class DisplayApplicationForm : Form
    {
        public string DataFile = string.Empty;

        public DisplayApplicationForm()
        {
            InitializeComponent();
        }

        private void DisplayApplicationForm_Load(object sender, EventArgs e)
        {
            if (DataFile == string.Empty)
            {
                MessageBox.Show("No Record is found in the system");
                return;
            }

            XDocument doc = XDocument.Load(DataFile);

            foreach (var dm in doc.Descendants("jobApplication"))
            {
                dateTimePickerCreatedOn.Value = DateTime.Parse(dm.Element("createdOn").Value);
                dateTimePickerModifiedOn.Value = DateTime.Parse(dm.Element("modifiedOn").Value);
                dateTimePickerAppliedOn.Value = DateTime.Parse(dm.Element("applicationDate").Value);
                dateTimePickerClosedOn.Value = DateTime.Parse(dm.Element("closedOn") == null ? "01/01/1981" : dm.Element("closedOn").Value);
                txtCompany.Text = dm.Element("company").Value;
                txtContact.Text = dm.Element("advertiser").Value;
                txtTitle.Text = dm.Element("title").Value;
                txtURL.Text = dm.Element("url").Value;
                txtBody.Text = dm.Element("advertisement").Value;

                //generate file
                try
                {
                    using (var fs = new FileStream("temp.docx", FileMode.Create, FileAccess.Write))
                    {
                        byte[] CVbody = Convert.FromBase64String(dm.Element("AppliedCVBinary").Value);
                        fs.Write(CVbody, 0, CVbody.Length);
                    }

                    officeViewer1.LoadFromFile("temp.docx");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught in process: {0}", ex);
                }
            }
        }

        private void DisplayApplicationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            officeViewer1.Dispose();

            GC.Collect();
            //delete file
            if (File.Exists("temp.docx"))
                File.Delete("temp.docx");
        }

        private void OfficeViewer1_DocumentOpened(object sender, EventArgs args)
        {
            if (this.MdiParent.MdiChildren.Length > 2)
                this.MdiParent.MdiChildren[0].Activate();

        }
    }
}
