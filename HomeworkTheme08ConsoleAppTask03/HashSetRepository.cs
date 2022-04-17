using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTheme08ConsoleAppTask03
{
    class HashSetRepository
    {
        private HashSet<int> SetInt { get; set; }

        public HashSetRepository()
        {
            SetInt = new HashSet<int>();
        }

        public HashSet<int> Add (int number)
        {
            SetInt.Add(number);
            return SetInt;
        }

        public void ChekingRepetitions(int number)
        {
            if (SetInt.Contains(number))
            {
                Console.WriteLine($"\nЧисло {number} уже вводилось ранее.");
            }
            else
            {
                Console.WriteLine($"\nЧисло {number} успешно сохранено.");
            }
        }

        public void PrintHashSet ()
        {
            foreach (var e in SetInt)
            {
                Console.Write($"{e} ");
            }
        }
    }
}
