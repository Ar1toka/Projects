using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат вычислений = " + string.Format("{0:F4}", (Math.Sqrt(x+1) + Math.Sqrt(x-1))/ (2 * Math.Sqrt(x))));
            Console.ReadLine();
        }
    }
}
