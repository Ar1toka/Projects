using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            const double g = 9.8067;
            Console.Write("Введите значение m: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение а: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат вычислений = "+string.Format("{0:F4}",( b * g * Math.Cos(Math.PI * a / 180))));
            Console.ReadLine();
        
        }
    }
}
