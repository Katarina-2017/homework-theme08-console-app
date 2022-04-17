using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTheme08ConsoleAppTask02
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionaryRepository = new DictionaryRepository();

            Console.WriteLine("Задание 2. Телефонная книга:");
            Console.WriteLine("Признаком того, что пользователь закончил вводить номера телефонов, является ввод пустой строки...");
            var myPhoneBook = dictionaryRepository.AddDictionary();
            dictionaryRepository.PrintDictionary(myPhoneBook);

            Console.WriteLine();
            Console.WriteLine("Введите номер телефона, чтобы найти владельца:");
            string phoneNumberInsert = Console.ReadLine();
            dictionaryRepository.OwnerSearch(myPhoneBook, phoneNumberInsert);

            Console.ReadKey();
        }
    }
}
