using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;
            Console.Write("Введите угол в градусах: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введённый угол в радианах = " + string.Format("{0:F4}",(a * PI) / 180));
            Console.ReadLine();
        }
    }
}
