using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат вычислений = " + string.Format("{0:F4}", (Math.Sqrt((x2*x2)+(x1*x1)))));
            Console.ReadLine();

        }
    }
}
