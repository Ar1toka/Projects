using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;
            Console.Write("Введите радиус окружности: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Объём шара = " + string.Format("{0:F4}",(4 * PI * (a*a*a))/3));
            Console.ReadLine();
        }
    }
}
