using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTheme08ConsoleAppTask03
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashSetRepository = new HashSetRepository();

            Console.WriteLine("Задание 3. Проверка повторов:");
            Console.WriteLine("Признаком того, что пользователь закончил вводить числа, является ввод пустой строки...");
            while (true)
            {
                Console.WriteLine("Введите число:");
                string userNumber = Console.ReadLine();
                if (int.TryParse(userNumber, out int result))
                {
                    hashSetRepository.ChekingRepetitions(result);
                    hashSetRepository.Add(result);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("У вас получилось такое множество:");
            hashSetRepository.PrintHashSet();

            Console.ReadKey();
        }
    }
}
