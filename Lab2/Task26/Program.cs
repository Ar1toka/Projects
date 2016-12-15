using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task26
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
            Console.Write("Введите значение d: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат вычислений = " + string.Format("{0:F4}", (((a * d) + (b * c)) / (a * d))));
            Console.ReadLine();
        }
    }
}
