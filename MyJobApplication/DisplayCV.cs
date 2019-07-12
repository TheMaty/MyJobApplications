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

namespace MyJobApplication
{
    public partial class DisplayCV : Form
    {
        public byte[] CVbody;
        public DisplayCV()
        {
            InitializeComponent();
        }

        private void DisplayCV_Load(object sender, EventArgs e)
        {
            //generate file
            try
            {
                using (var fs = new FileStream("temp.docx", FileMode.Create, FileAccess.Write))
                {
                    fs.Write(CVbody, 0, CVbody.Length);
                }

                officeViewer1.LoadFromFile("temp.docx");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in process: {0}", ex);
            }
        }

        private void DisplayCV_FormClosed(object sender, FormClosedEventArgs e)
        {
            officeViewer1.Dispose();
            
            GC.Collect();
            //delete file
            if (File.Exists("temp.docx"))
                File.Delete("temp.docx");
        }
    }
}
