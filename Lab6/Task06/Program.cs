using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 1;
            int c = 1;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine( c+"   "+b*453);
                c++;
                b++;
            }
            Console.ReadLine();
        }
    }
}
