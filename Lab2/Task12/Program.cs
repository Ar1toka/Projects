using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите угол: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат вычислений = "+ string.Format("{0:F4}",(5 * Math.Cos(Math.PI * a / 180))));
            Console.ReadLine();
        }
    }
}
