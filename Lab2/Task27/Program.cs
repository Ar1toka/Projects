using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат вычислений = " + string.Format("{0:F4}", (Math.Sqrt(1 - (Math.Sin(Math.PI * a / 180) * Math.Sin(Math.PI * a / 180))))));
            Console.ReadLine();
        }
    }
}
