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
    public partial class TreeViewForm : Form
    {
        string dbFilePath => ConfigurationManager.AppSettings["DBFile"];

        string[] records;

        public List<string> Companies = new List<string>();
        public List<string> Contacts = new List<string>();
        public List<string> Applications = new List<string>();

        public TreeViewForm()
        {
            int nodeLength = 0;
            InitializeComponent();

            records = Directory.GetFiles(dbFilePath);

            foreach (string dataFile in records)
            {
                XDocument doc = XDocument.Load(dataFile);
                foreach (var dm in doc.Descendants("jobApplication"))
                {
                    mainTreeView.Nodes[0].Nodes[0].Nodes.Add(new TreeNode() { Text = dm.Element("title").Value, Name = dm.Element("company").Value + "_" + dm.Element("title").Value });
                    nodeLength = dm.Element("title").Value.Length > nodeLength ? dm.Element("title").Value.Length : nodeLength;
                    Applications.Add(dm.Element("title").Value);

                    if (!mainTreeView.Nodes[0].Nodes[1].Nodes.ContainsKey(dm.Element("company").Value))
                    {
                        mainTreeView.Nodes[0].Nodes[1].Nodes.Add(new TreeNode() { Text = dm.Element("company").Value, Name = dm.Element("company").Value });
                        nodeLength = dm.Element("company").Value.Length > nodeLength ? dm.Element("company").Value.Length : nodeLength;
                        //add company filter to jobApplications so
                        //select all jobApplications for active company
                        string[] filteredApplicationsByCompanies = Array.FindAll(records, x => x.Contains(dm.Element("company").Value));
                        foreach (string dataFilteredByCompanies in filteredApplicationsByCompanies)
                        {
                            XDocument docFiltered = XDocument.Load(dataFilteredByCompanies);
                            foreach (var dmFiltered in docFiltered.Descendants("jobApplication"))
                            {
                                mainTreeView.Nodes[0].Nodes[1].Nodes[mainTreeView.Nodes[0].Nodes[1].Nodes.Count - 1].Nodes.Add(new TreeNode() { Text = dmFiltered.Element("title").Value, Name = dmFiltered.Element("company").Value + "_" + dmFiltered.Element("title").Value });
                            }
                        }

                        Companies.Add(dm.Element("company").Value);
                    }
                    if (dm.Element("advertiser").Value != "No Contact" && dm.Element("advertiser").Value != "N/A" && !mainTreeView.Nodes[0].Nodes[2].Nodes.ContainsKey(dm.Element("advertiser").Value))
                    {
                        mainTreeView.Nodes[0].Nodes[2].Nodes.Add(new TreeNode() { Text = dm.Element("advertiser").Value, Name = dm.Element("advertiser").Value });
                        nodeLength = dm.Element("advertiser").Value.Length > nodeLength ? dm.Element("advertiser").Value.Length : nodeLength;
                        //add company filter to jobApplications so
                        //select all jobApplications for active company
                        string[] filteredApplicationsByCompanies = Array.FindAll(records, x => x.Contains(dm.Element("company").Value));
                        foreach (string dataFilteredByCompanies in filteredApplicationsByCompanies)
                        {
                            XDocument docFiltered = XDocument.Load(dataFilteredByCompanies);
                            foreach (var dmFiltered in docFiltered.Descendants("jobApplication"))
                            {
                                mainTreeView.Nodes[0].Nodes[2].Nodes[mainTreeView.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes.Add(new TreeNode() { Text = dmFiltered.Element("title").Value, Name = dmFiltered.Element("company").Value + "_" + dmFiltered.Element("title").Value });
                            }
                        }

                        Contacts.Add(dm.Element("advertiser").Value);
                    }
                }

                foreach (var dm in doc.Descendants("jobActivity"))
                {
                    //check dublicate control
                    if (!mainTreeView.Nodes[0].Nodes[3].Nodes[0].Nodes.ContainsKey(Path.GetFileNameWithoutExtension(dataFile)))
                    {
                        mainTreeView.Nodes[0].Nodes[3].Nodes[0].Nodes.Add(new TreeNode() { Text = Path.GetFileNameWithoutExtension(dataFile), Name = Path.GetFileNameWithoutExtension(dataFile) });
                        nodeLength = Path.GetFileNameWithoutExtension(dataFile).Length > nodeLength ? Path.GetFileNameWithoutExtension(dataFile).Length : nodeLength;
                    }

                    if (dm.Element("regarding").Value != "" && !mainTreeView.Nodes[0].Nodes[3].Nodes[1].Nodes.ContainsKey(dm.Element("regarding").Value))
                    {
                        mainTreeView.Nodes[0].Nodes[3].Nodes[1].Nodes.Add(new TreeNode() { Text = dm.Element("regarding").Value, Name = dm.Element("regarding").Value });
                        nodeLength = dm.Element("regarding").Value.Length > nodeLength ? dm.Element("regarding").Value.Length : nodeLength;
                    }

                    //check dublicate control
                    if (!mainTreeView.Nodes[0].Nodes[3].Nodes[2].Nodes.ContainsKey(dm.Element("contact").Value))
                    {
                        mainTreeView.Nodes[0].Nodes[3].Nodes[2].Nodes.Add(new TreeNode() { Text = dm.Element("contact").Value, Name = dm.Element("contact").Value });
                        nodeLength = dm.Element("contact").Value.Length > nodeLength ? dm.Element("contact").Value.Length : nodeLength;
                    }

                }
            }
        }

        private void mainTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null && e.Button == MouseButtons.Left)
            {
                switch (e.Node.FullPath)
                {
                    case string a when a.Contains ("My Job Applications\\Applications\\"):
                    case string b when b.Contains ("My Job Applications\\Companies\\") && e.Node.Level == 3:
                    case string c when c.Contains ("My Job Applications\\Contacts\\") && e.Node.Level == 3:
                        DisplayApplicationForm appForm = new DisplayApplicationForm();
                        if(!Array.Exists(records, x => x.Contains(e.Node.Name)))
                        {
                            MessageBox.Show("No Record is found in the system");
                            return;
                        }
                        appForm.DataFile = Array.FindAll(records, x => x.Contains(e.Node.Name))[0];
                        if (this.MdiParent.MdiChildren.Length > 2)
                            this.MdiParent.MdiChildren[2].Close();
                        appForm.MdiParent = this.MdiParent;
                        appForm.Show();
                        this.MdiParent.MdiChildren[2].Activate();
                        break;
                    case string d when d.Contains("My Job Applications\\Activities\\Activities") && e.Node.Level == 2:
                        Activities actForm = new Activities(records);

                        if (this.MdiParent.MdiChildren.Length > 2)
                            this.MdiParent.MdiChildren[2].Close();
                        actForm.MdiParent = this.MdiParent;
                        actForm.Show();
                        this.MdiParent.MdiChildren[2].Activate();
                        break;
                    case string f when f.Contains("My Job Applications\\Activities\\Activities\\") && e.Node.Level == 3:
                        DisplayJobActivityForm jobActForm = new DisplayJobActivityForm();
                        if (!Array.Exists(records, x => x.Contains(e.Node.Name)))
                        {
                            MessageBox.Show("No Record is found in the system");
                            return;
                        }
                        jobActForm.DataFile = Array.FindAll(records, x => x.Contains(e.Node.Name))[0];
                        if (this.MdiParent.MdiChildren.Length > 2)
                            this.MdiParent.MdiChildren[2].Close();
                        jobActForm.MdiParent = this.MdiParent;
                        jobActForm.Show();
                        this.MdiParent.MdiChildren[2].Activate();
                        break;
                    case string g when g.Contains("My Job Applications\\Activities\\Regarding\\") && e.Node.Level == 3:
                        //search all activities for selected item
                        List<string> strParams = new List<string>();

                        foreach (string dataFile in records)
                        {
                            XDocument doc = XDocument.Load(dataFile);

                            foreach (var dm in doc.Descendants("jobActivity"))
                            {
                                if (dm.Element("regarding").Value.Contains(e.Node.Name))
                                    strParams.Add(dataFile);
                            }
                        }

                        actForm = new Activities(strParams.ToArray<string>());

                        if (this.MdiParent.MdiChildren.Length > 2)
                            this.MdiParent.MdiChildren[2].Close();
                        actForm.MdiParent = this.MdiParent;
                        actForm.Show();
                        this.MdiParent.MdiChildren[2].Activate();

                        break;
                    case string h when h.Contains("My Job Applications\\Activities\\Contacts\\") && e.Node.Level == 3:
                        actForm = new Activities(records.Where(x => x.Contains(e.Node.Name)).ToArray<string>());

                        if (this.MdiParent.MdiChildren.Length > 2)
                            this.MdiParent.MdiChildren[2].Close();
                        actForm.MdiParent = this.MdiParent;
                        actForm.Show();
                        this.MdiParent.MdiChildren[2].Activate();
                        break;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                switch (e.Node.Name)
                {
                    case "Applications":
                        JobApplicationForm jobApp = new JobApplicationForm();
                        if (this.MdiParent.MdiChildren.Length > 2)
                            this.MdiParent.MdiChildren[2].Close();
                        jobApp.MdiParent = this.MdiParent;
                        jobApp.Show();
                        break;
                    case "Companies":
                        break;
                    case "Contacts":
                        break;
                    case "Activities":
                        JobActivityForm jobAct = new JobActivityForm();
                        if (this.MdiParent.MdiChildren.Length > 2)
                            this.MdiParent.MdiChildren[2].Close();
                        jobAct.MdiParent = this.MdiParent;
                        jobAct.Show();
                        break;
                }
            }
        }

    }
}
