using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

public static class XMLSerializer
{
    private static string savePath = Application.StartupPath + @"\temp";
    public static void Save<T>(string fileName, T objToSerialize)
    {
        XmlSerializer xml = new XmlSerializer(typeof(T));

        using (FileStream stream = new FileStream(savePath + $"\\{fileName}.xml", FileMode.Create))
            xml.Serialize(stream, objToSerialize);
    }
    public static bool Exist(string fileName)
    {
        return File.Exists(savePath + $"\\{fileName}.xml");
    }
    public static T Load<T>(string fileName)
    {

        if (File.Exists(savePath + $"\\{fileName}.xml"))
        {
            T res;
            XmlSerializer xml = new XmlSerializer(typeof(T));

            using (FileStream stream = new FileStream(savePath + $"\\{fileName}.xml", FileMode.Open))
                res = (T)xml.Deserialize(stream);

            return res;
        }
        else
        {
            throw new Exception($"No file on load path");
        }


    }
}
