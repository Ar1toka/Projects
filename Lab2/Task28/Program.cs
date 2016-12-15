using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат вычислений = " + string.Format("{0:F4}", (1/ Math.Sqrt(a*(x*x)+b*x+c))));
            Console.ReadLine();
        }
    }
}
