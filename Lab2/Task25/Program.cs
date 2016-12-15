using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task25
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
            Console.WriteLine("Результат вычислений = " + string.Format("{0:F4}", (Math.Sqrt(((a * a) + (b * b)) - 2 * a * b * Math.Cos(Math.PI * c / 180)))));
            Console.ReadLine();
            
        }
    }
}
