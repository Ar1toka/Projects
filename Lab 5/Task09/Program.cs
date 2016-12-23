using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите площадь круга: ");
            double a = double.Parse(Console.ReadLine());
            while (a <= 0)
            {
                Console.WriteLine("Введите число больше 0");
                Console.Write("Введите площадь круга: ");
                a = double.Parse(Console.ReadLine());
            }

            Console.Write("Введите площадь квадрата: ");
            double b = double.Parse(Console.ReadLine());
            while (b <= 0)
            {
                Console.WriteLine("Введите число больше 0");
                Console.Write("Введите площадь квадрата: ");
                b = double.Parse(Console.ReadLine());
            }
            bool e = task9(a, b);
            if (e)//==true
                Console.WriteLine("Круг уместится в квадрате");
            if (!e)
                Console.WriteLine("Круг не уместится в квадрате");

            Console.ReadLine();
        }
        public static bool task9(double a, double b)
        {
            double c = (Math.Sqrt(a / Math.PI) * 2);
            double d = Math.Sqrt(b);

            return d > c;
            //if ( d > c)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

        }
    }
}
