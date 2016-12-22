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
        beginning:
            Console.Write("Введите значение а: ");
            double a = double.Parse(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Введите число больше 0");
                goto beginning;
            }
            Console.Write("Введите значение b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите значение c: ");
            double c = double.Parse(Console.ReadLine());
            double d = (b * b) - 4 * a * c;
            if (d == 0)
            {
                Console.WriteLine("Уравнение 3x^2 + 6x + 3 = 0 имеет один корень");
            }
            if (d > 0)
            {
                Console.WriteLine("У уравнения 3x^2 + 17x + 5 = 0 два вещественных корня");
            }
            if (d<0)
            {
                Console.WriteLine("Вещественных корней уравнения 1x^2 + 2x + 3 = 0 нет");
            }
            Console.WriteLine("Круг не уместится в квадрате");
            Console.ReadLine();
        }
    }
}
