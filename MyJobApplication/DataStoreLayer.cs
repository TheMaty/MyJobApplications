using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyJobApplication
{
    public struct jobApplication
    {
        public DateTime applicationDate;
        public DateTime createdOn;
        public DateTime modifiedOn;
        public string company;
        public string title;
        public string advertisement;
        public string url;
        public string advertiser;
        public byte[] AppliedCVBinary;
    }

    public struct jobActivity
    {
        public DateTime activityDate;
        public DateTime createdOn;
        public DateTime modifiedOn;
        public string title;
        public string body;
        public string regarding;
        public string contact;
        public string type;
    }


    public class DataStoreLayer
    {
        private string dbFilePath => ConfigurationManager.AppSettings["DBFile"];

        public DataStoreLayer()
        { }

        /// <summary>
        /// Saves to an xml file
        /// </summary>
        /// <param name="jobApplication">Strcut of the jobApplication</param>
        public bool InsertApplication(jobApplication jobApp)
        {                  
            using (var writer = new System.IO.StreamWriter(dbFilePath +"\\" + jobApp.applicationDate.ToString("yyyyMMddhhmm") + 
                "_" + 
                jobApp.company + "_" + jobApp.title + ".xml",true))
            {
                var serializer = new XmlSerializer(jobApp.GetType());
                serializer.Serialize(writer, jobApp);
                writer.Flush();
            }
            return true;
        }

        /// <summary>
        /// Saves to an xml file
        /// </summary>
        /// <param name="jobActivity">Strcut of the jobApplication</param>
        public bool InsertActivity(jobActivity jobAct)
        {
            using (var writer = new System.IO.StreamWriter(dbFilePath + "\\" + jobAct.activityDate.ToString("yyyyMMddhhmm") +
                "_" +
                jobAct.type + "_" + jobAct.contact + ".xml", true))
            {
                var serializer = new XmlSerializer(jobAct.GetType());
                serializer.Serialize(writer, jobAct);
                writer.Flush();
            }
            return true;
        }

        /// <summary>
        /// Load an object from an xml file
        /// </summary>
        /// <param name="FileName">Xml file name</param>
        /// <returns>The object created from the xml file</returns>
        public jobApplication LoadJobApplication(string FileName)
        {
            using (var stream = System.IO.File.OpenRead(FileName))
            {
                var serializer = new XmlSerializer(typeof(jobApplication));
                return (jobApplication) serializer.Deserialize(stream);
            }
        }

        /// <summary>
        /// Load an object from an xml file
        /// </summary>
        /// <param name="FileName">Xml file name</param>
        /// <returns>The object created from the xml file</returns>
        public jobActivity LoadJobActivity(string FileName)
        {
            using (var stream = System.IO.File.OpenRead(FileName))
            {
                var serializer = new XmlSerializer(typeof(jobApplication));
                return (jobActivity)serializer.Deserialize(stream);
            }
        }
    }
}
