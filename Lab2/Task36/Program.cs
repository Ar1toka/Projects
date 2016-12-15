using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение Xa: ");
            double xa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение Ya: ");
            double ya = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение Xb: ");
            double xb = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение Yb: ");
            double yb = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат вычислений = " + string.Format("{0:F4}", (Math.Sqrt(((xb - xa) * (xb - xa)) + ((yb - ya) * (yb - ya))))));
            Console.ReadLine();
        }
    }
}
