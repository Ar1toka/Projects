using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение X1: ");
            double x1 = double.Parse(Console.ReadLine());
            while (x1 <= 0)
            {
                Console.WriteLine("Значение X1 должно быть больше 0");
                Console.Write("Введите значение X1: ");
                x1 = double.Parse(Console.ReadLine());


            }
            Console.Write("Введите значение Y1: ");
            double y1 = double.Parse(Console.ReadLine());
            while (y1 <= 0)
            {
                Console.WriteLine("Значение Y1 должно быть больше 0");
                Console.Write("Введите значение Y1: ");
                y1 = double.Parse(Console.ReadLine());


            }
            Console.Write("Введите значение X2: ");
            double x2 = double.Parse(Console.ReadLine());
            //while (x2 <= 0)
            //{
            //    Console.WriteLine("Значение X2 должно быть больше 0");
            //    Console.Write("Введите значение X2: ");
            //    x2 = double.Parse(Console.ReadLine());


            //}
            Console.Write("Введите значение Y2: ");
            double y2 = double.Parse(Console.ReadLine());
            //while (y2 <= 0)
            //{
            //    Console.WriteLine("Значение Y2 должно быть больше 0");
            //    Console.Write("Введите значение Y2: ");
            //    y2 = double.Parse(Console.ReadLine());


            //}
            string c = Task4(x1, y1, x2, y2);
            Console.WriteLine(c);
            Console.WriteLine(Task4(0,	0,	20,	30	));
            Console.WriteLine(Task4(50,	50,	50,	100	));
            Console.WriteLine(Task4(40,	30,	60,	30	));
            Console.WriteLine(Task4(75,	25,	65,	35	));
            Console.WriteLine(Task4(65,	0,	75,	0	));
            Console.WriteLine(Task4(0,	65,	0,	75	));
            Console.WriteLine(Task4(0, 0, 80, 90));
            Console.ReadLine();

        }
        public static string Task4(double x1, double y1, double x2, double y2)
    {
            double a = x2-x1;
            double b = y2 - y1;
            return "(" + a + ";" + b + ")";
    }
    }
}
