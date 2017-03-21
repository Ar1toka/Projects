using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 7;
            int c = 0;
            for (int i = 0; i < 9; i++)
            {
                c = a * b;
                Console.WriteLine(a + " x " + b +" = " +c);
                a++;

            }
            Console.ReadLine();
        }
    }
}
