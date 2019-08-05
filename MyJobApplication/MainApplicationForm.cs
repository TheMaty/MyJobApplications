using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyJobApplication
{
    public partial class MainApplicationForm : Form
    {
        public MainApplicationForm()
        {
            InitializeComponent();
        }

        private void MainApplicationForm_Load(object sender, EventArgs e)
        {
            TreeViewForm treeViewForm = new TreeViewForm();
            treeViewForm.MdiParent = this;
            treeViewForm.Location = new Point(0, 0);
            treeViewForm.Size = new Size(treeViewForm.Size.Width, this.Size.Height);
            treeViewForm.Show();

            SearchForm searchForm = new SearchForm();
            searchForm.MdiParent = this;
            searchForm.Show();

            this.MdiChildren[1].Location = new Point(treeViewForm.Size.Width + 1, 0);
            this.MdiChildren[1].Size = new Size(this.Size.Width - treeViewForm.Size.Width, searchForm.Size.Height);

        }

        public void MainApplicationForm_Resize(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 && this.MdiChildren[0] is TreeViewForm )
                this.MdiChildren[0].Size = new Size(this.MdiChildren[0].Width, this.Height);

            if (this.MdiChildren.Length > 1)
                this.MdiChildren[1].Size = new Size(this.Width - this.MdiChildren[0].Width, this.MdiChildren[1].Height);
        }

        private void MainApplicationForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 2 )
            {
                this.MdiChildren[1].Size = new Size(this.Size.Width - this.MdiChildren[0].Size.Width, this.MdiChildren[1].Size.Height);
                this.MdiChildren[2].Size = new Size(this.Size.Width - this.MdiChildren[0].Size.Width, this.Size.Height - this.MdiChildren[1].Size.Height);
                this.MdiChildren[2].Location = new Point(this.MdiChildren[0].Size.Width + 1, this.MdiChildren[1].Size.Height + 1);
            }
        }
    }
}
