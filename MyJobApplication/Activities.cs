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
using System.Xml.Linq;

namespace MyJobApplication
{
    public partial class Activities : Form
    {
        string[] records;
        string key;

        public Activities(string[] paramRecords, string paramKey = "All")
        {
            InitializeComponent();

            records = paramRecords;
            key = paramKey;
        }

        private void ListViewActivities_DoubleClick(object sender, EventArgs e)
        {
            Point mousePosition = listViewActivities.PointToClient(Control.MousePosition);
            ListViewHitTestInfo hit = listViewActivities.HitTest(mousePosition);
            int columnindex = hit.Item.SubItems.IndexOf(hit.SubItem);

            switch (columnindex)
            {
                case 2: //Regarding
                    DisplayApplicationForm appForm = new DisplayApplicationForm();
                    appForm.DataFile = DataStoreLayer.GetFileNameFromTitle(listViewActivities.SelectedItems[0].SubItems[columnindex].Text);
                    appForm.MdiParent = this.MdiParent;

                    if (this.MdiParent.MdiChildren.Length > 2)
                        this.MdiParent.MdiChildren[2].Close();
                    appForm.Show();
                    appForm.MdiParent.MdiChildren[2].Activate();
                    break;
                case 5: //Body
                    DisplayBodyForm DisplayBodyForm = new DisplayBodyForm();
                    DisplayBodyForm.Body = listViewActivities.SelectedItems[0].SubItems[columnindex].Text;
                    DisplayBodyForm.ShowDialog(this);
                    break;
            }
        }
        public void RefreshListView()
        {
            //first clean listview
            listViewActivities.Items.Clear();

            //load XML under path from App.Config
            //retrieve files one by one
            /*
                * this.activityDate
                * this.title
                * this.regarding
                * this.contact
                * this.type
                * this.body
             */

            //filter by requested type if not "All"
            if (key != "All")
                records = Array.FindAll(records, x => x.Contains(key));

            foreach (string dataFile in records)
            {
                XDocument doc = XDocument.Load(dataFile);

                foreach (var dm in doc.Descendants("jobActivity"))
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        dm.Element("activityDate").Value,
                        dm.Element("title").Value,
                        dm.Element("regarding").Value,
                        dm.Element("contact").Value,
                        dm.Element("type").Value,
                        dm.Element("body").Value,

                    });
                    listViewActivities.Items.Add(item);
                }
            }
        }

        private void Activities_Load(object sender, EventArgs e)
        {
            RefreshListView();
        }
    }
}
