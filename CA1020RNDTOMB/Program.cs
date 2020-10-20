using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1020RNDTOMB
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] tomb = new int[10];
            for (int i = 0; i < 10; i++)
            {
                tomb[i] = rnd.Next(10, 100);
                Console.WriteLine(tomb[i]);
            }
            Console.ReadKey();
        }
    }
}
