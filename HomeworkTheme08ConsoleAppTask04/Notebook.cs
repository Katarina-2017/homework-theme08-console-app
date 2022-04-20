using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeworkTheme08ConsoleAppTask04
{
    class Notebook
    {
        private string path; // Путь к файлу с данными

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Path">Путь к файлу с данными</param>
        public Notebook(string Path)
        {
            this.path = Path;
        }

        /// <summary>
        /// Метод xContact - создает элемент Person с заданной структурой
        /// </summary>
        /// <param name="vFullName">ФИО человека</param>
        /// <param name="vStreet">название улицы</param>
        /// <param name="vHouseNumber">номер дома</param>
        /// <param name="vFlatNumber">номер квартиры</param>
        /// <param name="vMobilePhone">номер мобильного телефона</param>
        /// <param name="vFlatPhone">номер домашнего телефона</param>
        /// <returns></returns>
        private XElement xContact(string vFullName, string vStreet, string vHouseNumber, int vFlatNumber, string vMobilePhone, string vFlatPhone)
        {
            return new XElement("Person",
                                    new XAttribute("name", vFullName),
                                    new XElement("Address",
                                    new XElement("Street", vStreet),
                                    new XElement("HouseNumber", vHouseNumber),
                                    new XElement("FlatNumber", vFlatNumber)),
                                    new XElement("Phones",
                                    new XElement("MobilePhone", vMobilePhone),
                                    new XElement("FlatPhone", vFlatPhone)));
        }
        /// <summary>
        /// Метод Create -  создает xml файл, в котором есть введенная информация о контакте
        /// </summary>
        /// <param name="Path">Путь к файлу с данными</param>
        public void Create(string Path)
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

            FileInfo fileName = new FileInfo(path);
            if (fileName.Exists)
            {
                XDocument xDocumentNotebook = XDocument.Load(path);
                XElement root = xDocumentNotebook.Element("Notebook"); // Получаем корневой элемент

                if (root != null)
                {
                    root.Add(xContact(valueFullName,valueStreet, valueHouseNumber,valueFlatNumber, valueMobilePhone, valueFlatPhone)); // Добавляем новый элемент Person
                    xDocumentNotebook.Save(path);
                }
                else
                {
                    root.Add(xContact(valueFullName, valueStreet, valueHouseNumber, valueFlatNumber, valueMobilePhone, valueFlatPhone)); // Создаем новый элемент Person
                    xDocumentNotebook.Add(root);
                    xDocumentNotebook.Save(path);
                }
            }
            else
            {
                XDocument xDocumentNotebook = new XDocument();

                xDocumentNotebook.Add(new XElement("Notebook", 
                    xContact(valueFullName, valueStreet, valueHouseNumber, valueFlatNumber, valueMobilePhone, valueFlatPhone))); // Создаем новый элемент Person
                xDocumentNotebook.Save(path);
            }

            
            Console.WriteLine("Данные сохранены.");
        }
        /// <summary>
        /// Метод Print - выводит информацию, которая содержится в созданном xml файле на экран
        /// </summary>
        /// <param name="Path"></param>
        public void Print(string Path)
        {
            XDocument xDocumentNotebook = XDocument.Load(path);
            XElement root = xDocumentNotebook.Element("Notebook");

            Console.WriteLine("В записной книжке находятся:");

            if (root != null)
            {
                foreach (XElement person in root.Elements("Person")) // Проходим по всем элементам Person
                {

                    XAttribute name = person.Attribute("name");
                    XElement adress = person.Element("Address");
                    XElement street = adress.Element("Street");
                    XElement houseNumber = adress.Element("HouseNumber");
                    XElement flatNumber = adress.Element("FlatNumber");
                    XElement phones = person.Element("Phones");
                    XElement mobilePhone = phones.Element("MobilePhone");
                    XElement flatPhone = phones.Element("FlatPhone");

                    Console.WriteLine($"ФИО человека: {name.Value}");
                    Console.WriteLine($"Адрес:");
                    Console.WriteLine($"Название улицы: {street.Value}, номер дома: {houseNumber.Value}, номер квартиры: {flatNumber.Value}.");
                    Console.WriteLine($"Телефоны:");
                    Console.WriteLine($"Мобильный телефон: {mobilePhone.Value}, домашний телефон: {flatPhone.Value}.");

                    Console.WriteLine(); // Для разделения при выводе на консоль
                }
            }
        }
    }
}
