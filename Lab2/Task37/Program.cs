using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение V1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение T1: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение V2: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение T2: ");
            double d = Convert.ToDouble(Console.ReadLine());
            double e = a + c;
            Console.WriteLine("Температура смеси = " + string.Format("{0:F4}", ((a*b+c*d))/(e)) + " Объём смеси = " + e);
            Console.ReadLine();
        }
    }
}
