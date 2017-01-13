using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение X1: ");
            double x1 = double.Parse(Console.ReadLine());
            while (x1<0)
            {
                Console.WriteLine("Значение Х1 должно быть больше 0");
                Console.Write("Введите значение X1: ");
                x1 = double.Parse(Console.ReadLine());
                
                
            }
            Console.Write("Введите значение Y1: ");
            double y1 = double.Parse(Console.ReadLine());
            while (y1 < 0)
            {
                Console.WriteLine("Значение Y1 должно быть больше 0");
                Console.Write("Введите значение Y1: ");
                y1 = double.Parse(Console.ReadLine());


            }
            Console.Write("Введите значение H: ");
            double h = double.Parse(Console.ReadLine());
            while (h < 0)
            {
                Console.WriteLine("Значение H должно быть больше 0");
                Console.Write("Введите значение H: ");
                h = double.Parse(Console.ReadLine());


            }
            Console.Write("Введите значение W: ");
            double w = double.Parse(Console.ReadLine());
            while (w < 0)
            {
                Console.WriteLine("Значение W должно быть больше 0");
                Console.Write("Введите значение W: ");
                w = double.Parse(Console.ReadLine());
                
            }

            string c = Task1(x1,y1,h,w);
            Console.WriteLine(c);
            Console.WriteLine(Task1(0,	0	,2	,3));
            Console.WriteLine(Task1(0	,0	,1	,1));
            Console.WriteLine(Task1(219, 374, 51, 96));
            Console.ReadLine();
	


        }
        public static string Task1(double x1, double y1, double h, double w)
        {
            double a = x1 + w;
            double b = y1 + h;
            return "("+a+";"+b+")";
        }
    }
}
