using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyJobApplication;

namespace UserControls
{
    public partial class CompanyContactLookup : UserControl
    {
        public CompanyContact companyContact
        {
            get
            {
                return new CompanyContact() { FirstName = txtFullName.Text };
            }
        }
        public CompanyContactLookup()
        {
            InitializeComponent();
            dataGridViewMain.Visible = false;
        }
    }
}
