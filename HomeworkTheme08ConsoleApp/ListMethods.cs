using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTheme08ConsoleAppTask01
{
    class ListMethods
    {
        private List<int> listNumber { get; set; }

        public ListMethods()
        {
            listNumber = new List<int>();
        }

        public List<int> AddList()
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                listNumber.Add(rand.Next(0, 101));
            }
            return listNumber;
        }

        public void PrintList(List<int> numberList)
        {
            foreach (var itm in numberList)
            {
                Console.Write($"{itm} ");
            }
        }

        public List<int> DeleteNumber(List<int> numberList)
        {
            numberList.RemoveAll(l => l>25 && l<50);

            return numberList;
        }
    }
}
