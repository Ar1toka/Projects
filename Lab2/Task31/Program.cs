using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = ((7*(x*x))-(3*x)+6);
            Console.WriteLine("Результат вычислений = " + string.Format("{0:F4}", y));
            Console.ReadLine();
        }
    }
}
