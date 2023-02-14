using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Homework8_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Тип для серіалізації та десеріалізації.
            XmlSerializer serializer = new XmlSerializer(typeof(MyXML));

            MyXML xml = new MyXML();

            for (int i = 0; i < 10; i++)
            {
                xml.Items.Add("Element " + i); // Заповнення списку.
            }

            MemoryStream memStm = new MemoryStream();

            serializer.Serialize(memStm, xml);
            memStm.Position = 0;
            string result = new StreamReader(memStm).ReadToEnd();


            Console.WriteLine(result);


            Console.WriteLine(new string ('-',60) +"deserializeXML");


            MyXML deserializeXML;
            memStm.Position = 0;
            deserializeXML = serializer.Deserialize(memStm) as MyXML;


            Console.WriteLine(deserializeXML.ID);
            Console.WriteLine("Size     : {0}", deserializeXML.Size);
            Console.WriteLine("Position : {0}", deserializeXML.Position.ToString());
            foreach (string item in deserializeXML.Items)
            {
                Console.WriteLine(item);
            }





            Console.ReadKey();
        }
    }
}
