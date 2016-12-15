using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
        beginning:
            Console.Write("Введите трёхзначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 100)
            {
                Console.WriteLine("Введено число, содержащее меньше 3 знаков");
                goto beginning;
            }
            if (a > 999)
            {
                Console.WriteLine("Введено число, содержащее больше 3 знаков");
                goto beginning;
            }
            int b = 0;
            while (a > 0)
            {
                b += a % 10;
                a /= 10;
            }
            Console.WriteLine("Результат вычислений = " + b);
            Console.ReadLine();
        }
    }
}
