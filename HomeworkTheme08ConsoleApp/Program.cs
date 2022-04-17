using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTheme08ConsoleAppTask01
{
    class Program
    {
        static void Main(string[] args)
        {
            var listMethods = new ListMethods();

            Console.WriteLine("Задание 1. Работа с листом.\nИсходная коллекция:");
            var myListNumber = listMethods.AddList();
            listMethods.PrintList(myListNumber);

            Console.WriteLine();
            Console.WriteLine("\nИзмененная коллекция:");
            listMethods.DeleteNumber(myListNumber);
            listMethods.PrintList(myListNumber);

            Console.ReadKey();
        }
    }
}
