using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
        beginning:
            Console.Write("Введите значение X: ");
            double a = double.Parse(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Введите число больше 0");
                goto beginning;
            }
        beginning2:
            Console.Write("Введите значение Y: ");
            double b = double.Parse(Console.ReadLine());
            if (b <= 0)
            {
                Console.WriteLine("Введите число больше 0");
                goto beginning2;
            }
        beginning3:
            Console.Write("Введите значение Z: ");
            double c = double.Parse(Console.ReadLine());
            if (c <= 0)
            {
                Console.WriteLine("Введите число больше 0");
                goto beginning3;
            }
            if ((c == b) || (b == a) || (c == a))
            {
                Console.WriteLine("Треугольник является равнобедренным.");
            }
            else
            {
                Console.WriteLine("Треугольник не является равнобедренным.");
            }

            Console.ReadLine();
        }
    }
}
