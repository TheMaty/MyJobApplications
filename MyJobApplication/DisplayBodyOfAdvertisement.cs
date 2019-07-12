using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyJobApplication
{
    public partial class DisplayBodyOfAdvertisementForm : Form
    {
        public string Body;
        public DisplayBodyOfAdvertisementForm()
        {
            InitializeComponent();           
        }

        private void DisplayBodyOfAdvertisementForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Body;
        }
    }
}
