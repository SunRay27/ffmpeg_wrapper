using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

public static class XMLSerializer
{
    private static string savePath = AppDomain.CurrentDomain.BaseDirectory;
    private static string workingFolder = AppDomain.CurrentDomain.BaseDirectory;
    private static string tempFolder = workingFolder + @"\temp";
    public static void Save<T>(string fileName, T objToSerialize)
    {
        XmlSerializer xml = new XmlSerializer(typeof(T));

        using (FileStream stream = new FileStream(tempFolder + $"\\{fileName}.xml", FileMode.Create))
            xml.Serialize(stream, objToSerialize);
    }
    public static bool Exist(string fileName)
    {
        return File.Exists(tempFolder + $"\\{fileName}.xml");
    }
    public static T Load<T>(string fileName)
    {
        
        if (File.Exists(tempFolder + $"\\{fileName}.xml"))
        {
            T res;
            XmlSerializer xml = new XmlSerializer(typeof(T));

            using (FileStream stream = new FileStream(tempFolder + $"\\{fileName}.xml", FileMode.Open))
                res = (T)xml.Deserialize(stream);

            return res;
        }
        else
        {
            throw new Exception($"No file on load path");
        }

        
    }
}
