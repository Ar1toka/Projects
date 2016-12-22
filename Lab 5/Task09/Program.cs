using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;
            beginning:
            Console.Write("Введите площадь круга: ");
            double a = double.Parse(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Введите число больше 0");
                goto beginning;
            }
            beginning2:
            Console.Write("Введите площадь квадрата: ");
            double b = double.Parse(Console.ReadLine());
            if (b <= 0)
            {
                Console.WriteLine("Введите число больше 0");
                goto beginning2;
            }
            double c = (Math.Sqrt(a/PI)*2);
            double d = Math.Sqrt(b);

            if ( d > c)
            {
                Console.WriteLine("Круг уместится в квадрате");
            }
            else
            {
                Console.WriteLine("Круг не уместится в квадрате");
            }
           
            Console.ReadLine();
        }
    }
}
