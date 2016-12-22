using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение X: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Y: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Z: ");
            double c = double.Parse(Console.ReadLine());

            double x=0;
                double y=0;
                double z = 0;
            if ((a>-3) && (a<5))
            {
                x=a;
            }
            if ((a <= -3) || (a >= 5))
            {
                x = ;
            }
            if ((c == b) || (b == a) || (c == a))
            {
                Console.WriteLine("Среди чисел есть равные");
            }
            if ((c == b) || (b == a) || (c == a))
            {
                Console.WriteLine("Среди чисел есть равные");
            }

            Console.ReadLine();
        }
    }
}
