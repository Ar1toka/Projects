using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число K: ");
            int a = int.Parse(Console.ReadLine());
                        if (a > 0)
            {

                Console.WriteLine("Результат вычислений " + Math.Sqrt(a));
            }
            else
            {
                Console.WriteLine("Результат вычислений " + (a*a));
            }

            Console.ReadLine();
        }
    }
}
