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

        public TreeViewForm()
        {
            InitializeComponent();

            records = Directory.GetFiles(dbFilePath);

            foreach (string dataFile in records)
            {
                XDocument doc = XDocument.Load(dataFile);
                foreach (var dm in doc.Descendants("jobApplication"))
                {
                    mainTreeView.Nodes[0].Nodes[0].Nodes.Add(new TreeNode() { Text = dm.Element("title").Value, Name = dm.Element("company").Value + "_" + dm.Element("title").Value });

                    if (!mainTreeView.Nodes[0].Nodes[1].Nodes.ContainsKey(dm.Element("company").Value))
                    {
                        mainTreeView.Nodes[0].Nodes[1].Nodes.Add(new TreeNode() { Text = dm.Element("company").Value, Name = dm.Element("company").Value });
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
                        if (this.MdiParent.MdiChildren.Length > 1)
                            this.MdiParent.MdiChildren[1].Close();
                        appForm.MdiParent = this.MdiParent;
                        appForm.Show();
                        this.MdiParent.MdiChildren[1].Activate();
                        break;
                    case "Activities":
                        break;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                switch (e.Node.Name)
                {
                    case "Applications":
                        JobApplicationForm jobApp = new JobApplicationForm();
                        if (this.MdiParent.MdiChildren.Length > 1)
                            this.MdiParent.MdiChildren[1].Close();
                        jobApp.MdiParent = this.MdiParent;
                        jobApp.Show();
                        break;
                    case "Companies":
                        break;
                    case "Contacts":
                        break;
                    case "Activities":
                        break;
                }
            }
        }
    }
}
