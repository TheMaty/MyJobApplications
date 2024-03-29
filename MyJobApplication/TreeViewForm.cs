﻿using System;
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

        private void initiateTreeView(TreeNodeCollection coll)
        {
            for (int i=coll.Count-1; i>=0; i--)
            {
                if (coll[i].Nodes.Count > 0)
                    initiateTreeView(coll[i].Nodes);

                if (!coll[i].Name.Contains("__"))
                    mainTreeView.Nodes.Remove(coll[i]);
            }
        }

        private TreeNode GetNodeFromPath(TreeNode node, string path)
        {
            TreeNode foundNode = null;
            foreach (TreeNode tn in node.Nodes)
            {
                if (tn.FullPath == path)
                {
                    return tn;
                }
                else if (tn.Nodes.Count > 0)
                {
                    foundNode = GetNodeFromPath(tn, path);
                }
                if (foundNode != null)
                    return foundNode;
            }
            return null;
        }

        public void drawTree()
        {
            string fullPathOfSelectedNode = mainTreeView.SelectedNode==null?"":mainTreeView.SelectedNode.FullPath;
            initiateTreeView(mainTreeView.Nodes);

            int nodeLength = 0;
            records = Directory.GetFiles(dbFilePath);

            foreach (string dataFile in records)
            {
                XDocument doc = XDocument.Load(dataFile);
                foreach (var dm in doc.Descendants("jobApplication"))
                {
                    if (dataFile.Contains("closed_"))
                        mainTreeView.Nodes[0].Nodes[0].Nodes[1].Nodes.Add(new TreeNode() { Text = dm.Element("title").Value, Name = dm.Element("company").Value + "_" + dm.Element("title").Value });
                    else
                        mainTreeView.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(new TreeNode() { Text = dm.Element("title").Value, Name = dm.Element("company").Value + "_" + dm.Element("title").Value });

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
                        if (dm.Element("type").Value == "Follow Up")
                        {
                            mainTreeView.Nodes[0].Nodes[3].Nodes[3].Nodes.Add(new TreeNode() { Text = Path.GetFileNameWithoutExtension(dataFile), Name = Path.GetFileNameWithoutExtension(dataFile) });
                            nodeLength = Path.GetFileNameWithoutExtension(dataFile).Length > nodeLength ? Path.GetFileNameWithoutExtension(dataFile).Length : nodeLength;
                        }
                        else
                        {
                            mainTreeView.Nodes[0].Nodes[3].Nodes[0].Nodes.Add(new TreeNode() { Text = Path.GetFileNameWithoutExtension(dataFile), Name = Path.GetFileNameWithoutExtension(dataFile) });
                            nodeLength = Path.GetFileNameWithoutExtension(dataFile).Length > nodeLength ? Path.GetFileNameWithoutExtension(dataFile).Length : nodeLength;
                        }
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

            mainTreeView.SelectedNode = GetNodeFromPath(mainTreeView.Nodes[0], fullPathOfSelectedNode);
            mainTreeView.Select();
        }

        public TreeViewForm()
        {
            InitializeComponent();
            drawTree();
        }

        private void mainTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null && e.Button == MouseButtons.Left)
            {
                switch (e.Node.FullPath)
                {
                    case string a when a.Contains ("My Job Applications\\Applications\\") && e.Node.Level == 3:
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
                    case string i when i.Contains("My Job Applications\\Activities\\FollowUps\\") && e.Node.Level == 3:
                        jobActForm = new DisplayJobActivityForm();
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
                }

                mainTreeView.SelectedNode = e.Node;
            }

            if (e.Button == MouseButtons.Right)
            {
                switch (e.Node.FullPath)
                {
                    case "My Job Applications\\Applications":
                        mainTreeView.ContextMenuStrip = contextMenuStrip1;
                        contextMenuStrip1.Items[0].Visible = true;
                        contextMenuStrip1.Items[1].Visible = false;
                        contextMenuStrip1.Items[2].Visible = false;
                        contextMenuStrip1.Items[3].Visible = false;
                        contextMenuStrip1.Items[4].Visible = false;
                        break;
                    case string a when a.Contains("My Job Applications\\Applications\\Open") && e.Node.Level == 3:
                        mainTreeView.ContextMenuStrip = contextMenuStrip1;
                        contextMenuStrip1.Items[0].Visible = false;
                        contextMenuStrip1.Items[1].Visible = false;
                        contextMenuStrip1.Items[2].Visible = true;
                        contextMenuStrip1.Items[3].Visible = false;
                        contextMenuStrip1.Items[4].Visible = true;
                        break;
                    case "My Job Applications\\Activities":
                        mainTreeView.ContextMenuStrip = contextMenuStrip1;
                        contextMenuStrip1.Items[0].Visible = false;
                        contextMenuStrip1.Items[1].Visible = true;
                        contextMenuStrip1.Items[2].Visible = false;
                        contextMenuStrip1.Items[3].Visible = false;
                        contextMenuStrip1.Items[4].Visible = false;
                        break;
                    case string b when b.Contains("My Job Applications\\Activities\\FollowUps") && e.Node.Level == 3:
                        mainTreeView.ContextMenuStrip = contextMenuStrip1;
                        contextMenuStrip1.Items[0].Visible = false;
                        contextMenuStrip1.Items[1].Visible = false;
                        contextMenuStrip1.Items[2].Visible = false;
                        contextMenuStrip1.Items[3].Visible = true;
                        contextMenuStrip1.Items[4].Visible = false;
                        break;
                    default:
                        mainTreeView.ContextMenuStrip = null;
                        break;
                }
            }
        }

        private void CloseJobApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close Job Application
            string strFilePath = Array.FindAll(records, x => x.Contains(mainTreeView.SelectedNode.Name))[0];
            DataStoreLayer ds = new DataStoreLayer();
            jobApplication jApp = ds.LoadJobApplication(strFilePath);
            jApp.closedOn = DateTime.Now;
            File.Delete(Array.FindAll(records, x => x.Contains(mainTreeView.SelectedNode.Name))[0]);
            ds.InsertApplication(jApp);

            System.IO.File.Move(strFilePath, strFilePath.Replace(Path.GetFileNameWithoutExtension(strFilePath), "closed_" + Path.GetFileNameWithoutExtension(strFilePath)));
            drawTree();
        }

        private void AddActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add Activity
            JobActivityForm jobAct = new JobActivityForm();
            if (this.MdiParent.MdiChildren.Length > 2)
                this.MdiParent.MdiChildren[2].Close();
            jobAct.MdiParent = this.MdiParent;
            jobAct.Show();
        }

        private void ApplyForAJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Apply for a job
            JobApplicationForm jobApp = new JobApplicationForm();
            if (this.MdiParent.MdiChildren.Length > 2)
                this.MdiParent.MdiChildren[2].Close();
            jobApp.MdiParent = this.MdiParent;
            jobApp.Show();
        }

        private void StopFollowUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Terminates Follow Up
            string strFilePath = Array.FindAll(records, x => x.Contains(mainTreeView.SelectedNode.Name))[0];
            System.IO.File.Move(strFilePath, strFilePath.Replace(Path.GetFileNameWithoutExtension(strFilePath), "closed_" + Path.GetFileNameWithoutExtension(strFilePath)));
            drawTree();
        }

        private void CreateFollowUpsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create FollowUps from Job Application.
            jobApplication jApplication = new jobApplication();
            DataStoreLayer dstore = new DataStoreLayer();
            jApplication = dstore.LoadJobApplication(Array.FindAll(records, x => x.Contains(mainTreeView.SelectedNode.Name))[0]);
            JobActivityForm jobActForm = new JobActivityForm(jApplication);
            if (this.MdiParent.MdiChildren.Length > 2)
                this.MdiParent.MdiChildren[2].Close();
            jobActForm.MdiParent = this.MdiParent;
            jobActForm.Show();
            this.MdiParent.MdiChildren[2].Activate();
        }
    }
}
