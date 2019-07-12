using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Xml.Serialization;

namespace MyJobApplication
{
    public partial class CompanyLookup : UserControl
    {
        private string dbFilePath => ConfigurationManager.AppSettings["DBFile"];
        public Company company
        {
            get
            {
                return new Company() { name = txtBox.Text };
            }
        }

        public CompanyLookup()
        {
            InitializeComponent();
            dataGridViewCompany.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (File.Exists(dbFilePath + "\\Company.xml"))
            {
                using (var stream = System.IO.File.OpenRead(dbFilePath + "\\Company.xml"))
                {
                    var serializer = new XmlSerializer(typeof(Company));
                    object obj = (Company)serializer.Deserialize(stream);
                }
            }            
        }
    }
}
