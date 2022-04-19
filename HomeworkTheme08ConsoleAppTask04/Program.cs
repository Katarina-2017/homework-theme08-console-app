using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTheme08ConsoleAppTask04
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Notebook.xml";

            Notebook myNotebook = new Notebook(path);

            Console.WriteLine("Задание 4. Записная книжка:");
            myNotebook.Create(path);

            Console.ReadKey();
        }
    }
}
