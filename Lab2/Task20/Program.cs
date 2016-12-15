using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            const double g = 9.8067;
            Console.Write("Введите значение m: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение v: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение h: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат вычислений = " +string.Format("{0:F4}",( ((a * (b * b)) / 2) * (a * g * c))));
            Console.ReadLine();
        }
    }
}
