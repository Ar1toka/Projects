using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число x: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число y: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат вычислений = " + string.Format("{0:F4}",(-5 * Math.Sqrt(a + Math.Sqrt(b)))));
            Console.ReadLine();
        }
    }
}
