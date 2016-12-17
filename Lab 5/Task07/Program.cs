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
            const double PI = 3.1416;
            beginning:
            Console.Write("Введите радиус круга: ");
            double a = double.Parse(Console.ReadLine());
            if (a < 0)
                {
                    Console.WriteLine("Введите положительное число");
                    goto beginning;
                }
            beginning2:
            Console.Write("Введите сторону квадрата: ");
            double b = double.Parse(Console.ReadLine());
            if (b < 0)
            {
                Console.WriteLine("Введите положительное число");
                goto beginning2;
            }
            double c = 2 * PI * a;
            double d = 2 * b;
            if (b > a)
            {
                Console.WriteLine("Площадь квадрата больше площади круга");
            }
            else
            {
                Console.WriteLine("Площадь круга больше площади квадрата");
            }
            Console.ReadLine();
        }
    }
}
