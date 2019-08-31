using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FollowUp
{
    public static class TextboxExtension
    {
        private delegate void SetPropertyThreadSafeDelegate<TResult>(TextBox @this, Expression<Func<TResult>> property, TResult value);

        public static void SetPropertyThreadSafe<TResult>(this TextBox @this, Expression<Func<TResult>> property, TResult value)
        {
            var propertyInfo = (property.Body as MemberExpression).Member
                as PropertyInfo;

            if (propertyInfo == null ||
                !@this.GetType().IsSubclassOf(propertyInfo.ReflectedType) ||
                @this.GetType().GetProperty(propertyInfo.Name, propertyInfo.PropertyType) == null)
            {
                throw new ArgumentException("The lambda expression 'property' must reference a valid property on this Control.");
            }

            if (@this.InvokeRequired)
            {
                @this.Invoke(new SetPropertyThreadSafeDelegate<TResult>
                (SetPropertyThreadSafe),
                new object[] { @this, property, value });
            }
            else
            {
                @this.GetType().InvokeMember(
                    propertyInfo.Name,
                    BindingFlags.SetProperty,
                    null,
                    @this,
                    new object[] { value });
            }
        }
    }
    public partial class FollowUpForm : Form
    {
        private string dbFilePath => ConfigurationManager.AppSettings["DBFile"];

        private static int WM_QUERYENDSESSION = 0x11;
        private static bool systemShutdown = false;
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg == WM_QUERYENDSESSION)
            {
                //MessageBox.Show("queryendsession: this is a logoff, shutdown, or reboot");
                systemShutdown = true;
            }

            // If this is WM_QUERYENDSESSION, the closing event should be  
            // raised in the base WndProc.  
            base.WndProc(ref m);

        } //WndProc   

        public FollowUpForm()
        {
            InitializeComponent();
        }

        private void FollowUpForm_Load(object sender, EventArgs e)
        {
            Start();
        }

        private void FollowUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!systemShutdown)
                e.Cancel = true;
        }


        private void Start()
        {
            Thread thread = new Thread(() => {
                while (!systemShutdown)
                {
                    //Clean the screen
                    txtItems.SetPropertyThreadSafe(() => txtItems.Text, string.Empty);

                    string[] records = Directory.GetFiles(dbFilePath);

                    foreach (string dataFile in records)
                    {
                        if (dataFile.Contains("closed_"))
                            continue;

                        XDocument doc = XDocument.Load(dataFile);

                        foreach (var dm in doc.Descendants("jobActivity"))
                        {
                            if (dm.Element("type").Value == "Follow Up" 
                            /* dublicate control */
                            /*                            
                            && !txtItems.Text.Contains(dm.Element("title").Value + " - " + dm.Element("contact").Value + " - " + dm.Element("regarding").Value)
                            */
                            )
                            {
                                txtItems.SetPropertyThreadSafe(() => txtItems.Text, txtItems.Text + System.Environment.NewLine);
                                txtItems.SetPropertyThreadSafe(() => txtItems.Text, txtItems.Text + " ********** ");
                                txtItems.SetPropertyThreadSafe(() => txtItems.Text, txtItems.Text + System.Environment.NewLine);
                                txtItems.SetPropertyThreadSafe(() => txtItems.Text, txtItems.Text + dm.Element("title").Value + " - " + dm.Element("contact").Value + " - " + dm.Element("regarding").Value);
                                txtItems.SetPropertyThreadSafe(() => txtItems.Text, txtItems.Text + System.Environment.NewLine);
                                txtItems.SetPropertyThreadSafe(() => txtItems.Text, txtItems.Text + " ********** ");
                            }
                        }
                    }
                    txtItems.SetPropertyThreadSafe(() => txtItems.SelectionStart, txtItems.Text.Length);

                    int refreshIteration = 0;

                    if(int.TryParse(ConfigurationManager.AppSettings["RefreshIteration"], out refreshIteration))
                        Thread.Sleep(refreshIteration);
                    else
                        Thread.Sleep(600000);


                }

                this.Close();
            });
            thread.Start();
        }
    }
}
