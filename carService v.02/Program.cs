using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
namespace carService_v._02
{
    class Program
    {
        public static CarService LoadXml(string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            if (!File.Exists(path))
            {
                Console.WriteLine("Нет доступа к файлу {0}", path);
                return null;
            }
            else
            {
                Console.WriteLine("Началась обработка данных");
            }
            try
            {
                MemoryStream rewData = new MemoryStream(File.ReadAllBytes(path));
                XmlSerializer xmls = new XmlSerializer(typeof(CarService));
                var XmlList = (CarService)xmls.Deserialize(rewData);
                Console.WriteLine("xml обратан");
                return XmlList;
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка обработки данных xml");
                return null;
            }
        }
        static void Main(string[] args)
        {
            string path = "carService3.xml";
            var result = LoadXml(path);
        }
    }
}
