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
using System.Windows.Input;
using System.Xml.Linq;

namespace MyJobApplication
{
    public partial class SearchForm : Form
    {
        private string dbFilePath => ConfigurationManager.AppSettings["DBFile"];
        AutoCompleteStringCollection data;
        string[] records;

        // Autocomplete works with all words matching with datasource
        // I want to make it more usefull since it is for search purpose
        // OOB AutoComplete continues matching after space "Dynamics CRM" any CRM starts with Dynamics will display
        // But, in this model "Dynamics CRM" will be independent so once you click space, systems matches typings without Dynamics so any CRM will still display 
        string autocompleteForMultipleValue = "";
        bool autocompletePairing = false;

        public SearchForm()
        {
            InitializeComponent();

            records = Directory.GetFiles(dbFilePath);
        }

        private void addKey(string str)
        {
            if (data == null) data = new AutoCompleteStringCollection();

            if (!data.Contains(str))
                data.Add(str);
        }

        private void addKey(string[] strColl)
        {
            if (data == null) data = new AutoCompleteStringCollection();

            foreach (string str in strColl)
            {
                if (!data.Contains(str))
                    data.Add(str);
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            foreach (string dataFile in records)
            {

                XDocument doc = XDocument.Load(dataFile);

                foreach (var dm in doc.Descendants("jobApplication"))
                {
                    addKey(dm.Element("company").Value.Split(' '));
                    addKey(dm.Element("advertiser").Value.Split(' '));
                    addKey(dm.Element("title").Value.Split(' '));
                    addKey(dm.Element("url").Value.Split(' '));
                    addKey(dm.Element("advertisement").Value.Split(' '));
                }
            }

            txtSearch.AutoCompleteCustomSource = data;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            List<string> results = new List<string>(records);
            
            string[] keys = txtSearch.Text.Split(' ');

            foreach(string key in keys)
            {
                foreach(string record in records)
                {
                    XDocument doc = XDocument.Load(record);

                    if (!doc.ToString().Contains(key))
                        results.Remove(record);
                }
            }


            Applications appForm = new Applications(results.ToArray());

            if (this.MdiParent.MdiChildren.Length > 2)
                this.MdiParent.MdiChildren[2].Close();
            appForm.MdiParent = this.MdiParent;
            appForm.Show();
            this.MdiParent.MdiChildren[2].Activate();
        }

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
                if (autocompletePairing)
                {
                    autocompleteForMultipleValue += " " + txtSearch.Text;
                    txtSearch.Text = autocompleteForMultipleValue;
                    txtSearch.SelectionStart = txtSearch.Text.Length;
                    txtSearch.SelectionLength = 0;
                    autocompletePairing = false;
                }
                else
                {
                    autocompleteForMultipleValue = txtSearch.Text;
                    txtSearch.Text = string.Empty;
                    autocompletePairing = true;
                }
            }
            
        }
    }
}
