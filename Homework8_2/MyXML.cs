using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml.Serialization;

namespace Homework8_2
{
    

        // XmlRoot - Перейменовує кореневий вузол.
        [XmlRoot("MyButton")]
        public class MyXML
        {
            private string id = "button";
            private int size = 10;
            private Point position = new Point(20, 30);
            private string password = "1234567890_password";
            private List<string> items = new List<string>();


            // XML атрибут перейменовуємо та робимо атрибутом.
            [XmlAttribute("SerialID")]
            public string ID
            {
                get { return id; }
                set { id = value; }
            }

            //XML атрибут.
            [XmlAttribute("Length")]
            public int Size
            {
                get { return size; }
                set { size = value; }
            }

            //XML елемент.
            [XmlElement("Pos")]
            public Point Position
            {
                get { return position; }
                set { position = value; }
            }

            // Виключаємо властивість із процесу серіалізації/десеріалізації.
            [XmlIgnore]
            public string Password
            {
                get { return password; }
                set { password = value; }
            }

            // Характеристика масиву.
            [XmlArray("List")]
            // Характеристика кожного елементу масиву.
            [XmlArrayItem("Element")]
            public List<string> Items
            {
                get { return items; }
                set { items = value; }
            }
        }



    
}
