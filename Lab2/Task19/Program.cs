using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение v0: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение t: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение a: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат вычислений = " + string.Format("{0:F4}", (a*b)+((c*(b*b))/2)));
            Console.ReadLine();
        }
    }
}
