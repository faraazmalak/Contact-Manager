using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;


namespace DataRW
{
    public class DataRW
    {
        public static void WriteData(string XMLData, string AppVersion)
        {
            string DataFilePath = string.Concat(PathGenerator.PathGen.GetPath(PathGenerator.PathGen.PathType.DocContactsDir), @"\Contacts.cstore");
           

             ContactDatabaseStructure  File = new ContactDatabaseStructure();
            File.XMLData = XMLData;
            File.AppVersion = AppVersion;

            BinaryFormatter Formatter = new BinaryFormatter();
            FileStream Stream = new FileStream(DataFilePath, FileMode.Create);
            Formatter.Serialize(Stream, File);
            Stream.Close();
           

        }


        public static bool ReadFile()
        {
            string DataFilePath = string.Concat(PathGenerator.PathGen.GetPath(PathGenerator.PathGen.PathType.DocContactsDir), @"\Contacts.cstore");
            string XMLDataFilePath = string.Concat(PathGenerator.PathGen.GetPath(PathGenerator.PathGen.PathType.DocContactsDir), @"\Contacts.xml");
            string XMLData = "";
            bool rESULT = false;    

            if (System.IO.File.Exists(DataFilePath) == true)
            {
                ContactDatabaseStructure File = new ContactDatabaseStructure();

                BinaryFormatter Formatter = new BinaryFormatter();
                FileStream Stream = new FileStream(DataFilePath, FileMode.Open);
               File = (ContactDatabaseStructure) Formatter.Deserialize(Stream);
              
                Stream.Close();
 XMLData = File.XMLData;

 System.IO.File.WriteAllText( XMLDataFilePath,XMLData);
 rESULT = true; ;

            }

            else if (System.IO.File.Exists(DataFilePath) == false)
            {
                rESULT = false;

            }
            return rESULT;
        }

        public static void test(string XMLData, string AppVersion)
        {

            string DataFilePath = string.Concat(PathGenerator.PathGen.GetPath(PathGenerator.PathGen.PathType.DocContactsDir), @"\Contacts.cstore");


            ContactDatabaseStructure File = new ContactDatabaseStructure();
            File.XMLData = XMLData;
            File.AppVersion = AppVersion;

            BinaryFormatter Formatter = new BinaryFormatter();
            FileStream Stream = new FileStream(DataFilePath, FileMode.Create);
            Formatter.Serialize(Stream, File);
            Stream.Close();
        }
    }
}
