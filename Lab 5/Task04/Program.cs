using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int a = int.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Aбсолютное значение A: " + a*(-1));
                //Console.WriteLine("Aбсолютное значение A: " + Math.Abs(a));
            }
            else
            {
                Console.WriteLine("Aбсолютное значение A: " + a);
            }

            Console.ReadLine();
        }
    }
}
