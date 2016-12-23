using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Z: ");
            double z = double.Parse(Console.ReadLine());

            double a = Task15(x, y, z);

            //double x= Math.Max(a,b);
            //double y = Math.Max(x,c);

            //    Console.WriteLine("Результат сравнения: "+y);

            Console.WriteLine(a);
            Console.WriteLine(Task15(1,2,3));
            Console.WriteLine(Task15(7,4,-2));
            Console.WriteLine(Task15(0,5,-7));

            Console.ReadLine();
        }
        public static double Task15(double x, double y, double z)
        {
            if (x > y && x > z)
                return x;
            if (y > x && y > z)
                return y;
            return z;
        }
    }
}
