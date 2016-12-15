using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение m1: ");
            double m1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение m2: ");
            double m2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение r: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат вычислений = " + string.Format("{0:F4}", (y*((m1*m2)/(r*r)))));
            Console.ReadLine();
        }
    }
}
