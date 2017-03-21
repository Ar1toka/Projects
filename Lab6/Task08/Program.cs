using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 0;
            for (int i = 0; i < 401; i++)
            {
                b = b + a;
                a++;

            }
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
