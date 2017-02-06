using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
           double a1 = 0;
             double   a2 = 0;
             double   b1 = 0;
              double      b2 = 0;
            Console.WriteLine("Введите значение X1: ");
            double x1 = double.Parse(Console.ReadLine());
            //while (x1 <= 0)
            //{
            //    Console.WriteLine("Значение X1 должно быть больше 0");
            //    Console.Write("Введите значение X1: ");
            //    x1 = double.Parse(Console.ReadLine());


            //}
            Console.Write("Введите значение Y1: ");
            double y1 = double.Parse(Console.ReadLine());
            //while (y1 <= 0)
            //{
            //    Console.WriteLine("Значение Y1 должно быть больше 0");
            //    Console.Write("Введите значение Y1: ");
            //    y1 = double.Parse(Console.ReadLine());


            //}
            Console.WriteLine("Введите значение X2: ");
            double x2 = double.Parse(Console.ReadLine());
            //while (x2 <= 0)
            //{
            //    Console.WriteLine("Значение X2 должно быть больше 0");
            //    Console.Write("Введите значение X2: ");
            //    x2 = double.Parse(Console.ReadLine());


            //}
            Console.WriteLine("Введите значение Y2: ");
            double y2 = double.Parse(Console.ReadLine());
            //while (y2 <= 0)
            //{
            //    Console.WriteLine("Значение Y2 должно быть больше 0");
            //    Console.Write("Введите значение Y2: ");
            //    y2 = double.Parse(Console.ReadLine());


            //}
            Console.WriteLine("Введите значение a: ");
            double a = double.Parse(Console.ReadLine());
            //while (y2 <= 0)
            //{
            //    Console.WriteLine("Значение Y2 должно быть больше 0");
            //    Console.Write("Введите значение Y2: ");
            //    y2 = double.Parse(Console.ReadLine());


            //}
            
            
            
            a1 = Math.Cos( a);
            a2 = -Math.Sin(a);
            b1 = Math.Sin( a);
            b2 = Math.Cos( a);
        }
    }
}
