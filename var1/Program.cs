using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            int max;

            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(-1);
            list.Add(4);
            void MAX(List<int> _list)
            {
                max = list.Max();
            }
            MAX(list);
            Console.Write(max);
            
            Console.ReadLine();

        }
    }
}