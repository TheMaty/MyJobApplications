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
    public partial class Applications : Form
    {
        string[] records;
        string key;

        public Applications(string[] paramRecords, string paramKey = "All")
        {
            InitializeComponent();

            records = paramRecords;
            key = paramKey;
        }

        private void listViewApplications_DoubleClick(object sender, EventArgs e)
        {
            Point mousePosition = listViewApplications.PointToClient(Control.MousePosition);
            ListViewHitTestInfo hit = listViewApplications.HitTest(mousePosition);
            int columnindex = hit.Item.SubItems.IndexOf(hit.SubItem);

            switch (columnindex)
            {
                case 5: // Body of Advertisement
                    DisplayBodyForm DisplayBodyForm = new DisplayBodyForm();
                    DisplayBodyForm.Body = listViewApplications.SelectedItems[0].SubItems[columnindex].Text;
                    DisplayBodyForm.ShowDialog(this);
                    break;
                case 6: //CV
                    DisplayCV displayCV = new DisplayCV();
                    displayCV.CVbody = Convert.FromBase64String(listViewApplications.SelectedItems[0].SubItems[columnindex].Text);
                    displayCV.ShowDialog(this);
                    break;
            }
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

            //filter by requested type if not "All"
            if (key != "All")
                records = Array.FindAll(records, x => x.Contains(key));
            
            foreach (string dataFile in records)
            {

                XDocument doc = XDocument.Load(dataFile);

                foreach (var dm in doc.Descendants("jobApplication"))
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        dm.Element("applicationDate").Value, //automatic value ! if error occurs,system must throw an exception even poor performance happens.
                        dm.Element("company")!=null?dm.Element("company").Value:"",
                        dm.Element("advertiser")!=null?dm.Element("advertiser").Value:"",
                        dm.Element("title")!=null?dm.Element("title").Value:"",
                        dm.Element("url")!=null?dm.Element("url").Value:"",
                        dm.Element("advertisement")!=null?dm.Element("advertisement").Value:"",
                        dm.Element("AppliedCVBinary")!=null?dm.Element("AppliedCVBinary").Value:"",

                    });
                    listViewApplications.Items.Add(item);
                }
            }
        }
        private void ApplicationsForm_Load(object sender, EventArgs e)
        {
            RefreshListView();
        }
    }
}
