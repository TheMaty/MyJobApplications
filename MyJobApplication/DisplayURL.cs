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
    public partial class DisplayURLForm : Form
    {
        public string URL;
        public DisplayURLForm()
        {
            InitializeComponent();           
        }

        private void DisplayBodyForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = URL;
        }
    }
}
