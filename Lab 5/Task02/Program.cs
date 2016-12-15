using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число P: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число Q: ");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Максимальное " + a + ", минимальное " + b);
            }
            else
            {
                Console.WriteLine("Максимальное " + b + ", минимальное " + a);
            }

            Console.ReadLine();
        }
    }
}
