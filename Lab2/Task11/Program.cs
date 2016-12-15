using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Квадратный корень = " + string.Format("{0:F4}",Math.Sqrt(a)));
            Console.ReadLine();
        }
    }
}
