using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTheme08ConsoleAppTask02
{
    class DictionaryRepository
    {
        private Dictionary<string,string> phoneBook { get; set; }

        public DictionaryRepository()
        {
            phoneBook = new Dictionary<string, string>();
        }

        public Dictionary<string,string> AddDictionary()
        {
            while (true)
            {
                Console.WriteLine("Введите номер телефона:");
                string phoneNumber = Console.ReadLine();

                if (string.IsNullOrEmpty(phoneNumber))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введите ФИО владельца:");
                    string fullName = Console.ReadLine();
                    if (string.IsNullOrEmpty(fullName))
                    {
                        break;
                    }
                    else
                    {
                        phoneBook.Add(phoneNumber, fullName);
                    }
                }

            }

            return phoneBook;
        }

        public void OwnerSearch(Dictionary<string, string> keyValuePairs, string phoneNumber)
        {
            string value = "";
            if (keyValuePairs.TryGetValue(phoneNumber, out value))
            {
                Console.WriteLine("По данному номеру телефона - {0}, найден владелец - {1}.", phoneNumber,value);
            }
            else
            {
                Console.WriteLine("По данному номеру телефона {0} владельца не зарегистрировано.", phoneNumber);
            }
        }

        public void PrintDictionary(Dictionary<string, string> keyValuePairs)
        {
            foreach (var valuePair in keyValuePairs)
            {
                Console.WriteLine($"Номер телефона: {valuePair.Key}  ФИО владельца: {valuePair.Value}");
            }
        }
    }
}
