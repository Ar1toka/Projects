using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение высоты: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = 6350;
            double c = b + a;
            Console.WriteLine("Результат вычислений = " + string.Format("{0:F4}", (Math.Sqrt((c * c) - (b * b)))));
            Console.ReadLine();
        }
    }
}
