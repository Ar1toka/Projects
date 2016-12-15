using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение R1: ");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение R2: ");
            double r2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат вычислений = " + string.Format("{0:F4}", ((1/r1)+(1/r2))));
            Console.ReadLine();
        }
    }
}
