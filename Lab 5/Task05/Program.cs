using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение L в километрах: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение P в футах: ");
            double b = double.Parse(Console.ReadLine());
            const double c = 0.305;
            double d = a * 1000;
            double e = b * c;
            if (d > e)
            {
                Console.WriteLine("Расстояние в футах меньше");
            }
            else
            {
                Console.WriteLine("Расстояние в километрах меньше");
            }

            Console.ReadLine();
        }
    }
}
