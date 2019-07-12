using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyJobApplication
{
    public partial class JobApplicationForm : Form
    {
        private string dbFilePath => ConfigurationManager.AppSettings["DBFile"];

        public JobApplicationForm()
        {
            InitializeComponent();
        }


        private void mainTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (mainTreeView.SelectedNode != null)
                {
                    switch (mainTreeView.SelectedNode.Name)
                    {
                        case "MyApplications":
                            DisplayJobApplication jobApp = new DisplayJobApplication();
                            jobApp.Show(this);
                            break;
                        case "Companies":
                            break;
                        case "CompanyContacts":
                            break;
                    }
                }
            }
        }

        private void JobApplicationForm_Load(object sender, EventArgs e)
        {
            mainTreeView.ExpandAll();
            RefreshListView();

           
        }

        public void RefreshListView()
        {
            //first clean listview
            listViewApplications.Items.Clear();

            //load XML under path from App.Config
            //retrieve files one by one
            /*
                * this.Company,
                * this.Advertiser,
                * this.Title,
                * this.URL,
                * this.Advertisement,
                * this.CV
             */

            string[] records = Directory.GetFiles(dbFilePath);

            foreach (string dataFile in records)
            {

                XDocument doc = XDocument.Load(dataFile);

                foreach (var dm in doc.Descendants("jobApplication"))
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        dm.Element("applicationDate").Value,
                        dm.Element("company").Value,
                        dm.Element("advertiser").Value,
                        dm.Element("title").Value,
                        dm.Element("url").Value,
                        dm.Element("advertisement").Value,
                        dm.Element("AppliedCVBinary").Value,

                    });
                    listViewApplications.Items.Add(item);
                }
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            Point mousePosition = listViewApplications.PointToClient(Control.MousePosition);
            ListViewHitTestInfo hit = listViewApplications.HitTest(mousePosition);
            int columnindex = hit.Item.SubItems.IndexOf(hit.SubItem);

            switch (columnindex)
            {
                case 5: // Body of Advertisement
                    DisplayBodyOfAdvertisementForm displayBodyOfAdvertisementForm = new DisplayBodyOfAdvertisementForm();
                    displayBodyOfAdvertisementForm.Body = listViewApplications.SelectedItems[0].SubItems[columnindex].Text;
                    displayBodyOfAdvertisementForm.ShowDialog(this);
                    break;
                case 6: //CV
                    DisplayCV displayCV = new DisplayCV();
                    displayCV.CVbody = Convert.FromBase64String(listViewApplications.SelectedItems[0].SubItems[columnindex].Text);
                    displayCV.ShowDialog(this);
                    break;
            }
        }
    }
}
