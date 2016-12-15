using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = ((12 * (a * a)) + (7 * a) - 16);
            Console.WriteLine("Результат вычислений = " + string.Format("{0:F4}", b));
            Console.ReadLine();
        }
    }
}
