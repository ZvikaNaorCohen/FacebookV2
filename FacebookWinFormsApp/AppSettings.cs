using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class AppSettings
    {
        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        public AppSettings()
        {
            RememberUser = false;
            LastAccessToken = "";
        }

        //public static AppSettings LoadFromFile()
        //{
        //    //AppSettings obj = null;
        //    //if (File.Exists(@"C:\appSettings.xml"))
        //    //{
        //    //    using (Stream stream = new FileStream("", FileMode.Open))
        //    //    {
        //    //        XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
        //    //        obj = serializer.Deserialize(stream) as AppSettings;
        //    //    }
        //    //}

        //    //return obj;

        //    return null;
        //}

        //public void SaveToFile()
        //{
        //    using (Stream stream = new FileStream(@"C:\appSettings.xml", FileMode.Truncate))
        //    {
        //        XmlSerializer serializer = new XmlSerializer(this.GetType());
        //        serializer.Serialize(stream, this);
        //    }
        //}
    }
}
