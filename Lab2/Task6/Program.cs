using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите основание прямоугольного треугольника: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту прямоугольного треугольника: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь прямоугольного треугольника = " + (a * b)/ 2);
            Console.ReadLine();
        }
    }
}
