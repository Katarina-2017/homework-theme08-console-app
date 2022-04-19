using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeworkTheme08ConsoleAppTask04
{
    class Notebook
    {
        private string path; // Путь к файлу с данными
        private List<Contact> Contacts { get; set; }

        public Notebook (string Path)
        {
            this.path = Path;

            Contacts = new List<Contact>();
        }

        public void Create(string Path)
        {
            char key = 'д';

            do
            {
                Console.WriteLine($"\nВведите ФИО человека:");
                string valueFullName = Console.ReadLine();

                Console.WriteLine("Введите название улицы: ");
                string valueStreet = Console.ReadLine();

                Console.WriteLine("Введите номер дома: ");
                string valueHouseNumber = Console.ReadLine();

                Console.WriteLine("Введите номер квартиры: ");
                int valueFlatNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите номер мобильного телефона: ");
                string valueMobilePhone = Console.ReadLine();

                Console.WriteLine("Введите номер домашнего телефона: ");
                string valueFlatPhone = Console.ReadLine();

                Contacts.Add(new Contact(valueFullName, valueStreet, valueHouseNumber, valueFlatNumber, valueMobilePhone, valueFlatPhone));
                Console.WriteLine("Продолжить н/д"); key = Console.ReadKey(true).KeyChar;
            } while (char.ToLower(key) == 'н');

            XDocument xDocumentNotebook = XDocument.Load(path);
            XElement root = xDocumentNotebook.Element("Notebook");

            if (root != null)
            {
                root.Add(Contacts.Select(c =>
                                new XElement("Person",
                                new XAttribute("name", c.FullName),
                                new XElement("Address"),
                                new XElement("Street", c.Street),
                                new XElement("HouseNumber", c.HouseNumber),
                                new XElement("Phones"),
                                new XElement("MobilePhone", c.MobilePhone),
                                new XElement("FlatPhone", c.FlatPhone))));

                xDocumentNotebook.Save(path);
            }
            else
            {
                XElement xContact =
                    new XElement("Notebook",
                            Contacts.Select(c =>
                                new XElement("Person",
                                new XAttribute("name", c.FullName),
                                new XElement("Address"),
                                new XElement("Street", c.Street),
                                new XElement("HouseNumber", c.HouseNumber),
                                new XElement("Phones"),
                                new XElement("MobilePhone", c.MobilePhone),
                                new XElement("FlatPhone", c.FlatPhone))));

                xDocumentNotebook.Add(xContact);
                xDocumentNotebook.Save(path);
            }

            Console.WriteLine("Данные сохранены.");
        }
    }
}
