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
        /// Load an object from an xml file
        /// </summary>
        /// <param name="FileName">Xml file name</param>
        /// <returns>The object created from the xml file</returns>
        public jobApplication Load(string FileName)
        {
            using (var stream = System.IO.File.OpenRead(FileName))
            {
                var serializer = new XmlSerializer(typeof(jobApplication));
                return (jobApplication) serializer.Deserialize(stream);
            }
        }
    }
}
