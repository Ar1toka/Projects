using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение X: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Y: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Z: ");
            double c = double.Parse(Console.ReadLine());
            string d = Task13(a, b, c);
            Console.WriteLine(d);
            Console.WriteLine(Task13(6.35, 2.7, 5.08));
            Console.WriteLine(Task13(4.71, 2.59, -18.55));
            Console.WriteLine(Task13(19.99, -1.57, 2.75));
            Console.WriteLine(Task13(-2.28, 16.92, 6.14));


            Console.ReadLine();
        }
        public static string Task13(double a, double b, double c)
        {
            double x = 0;
            double y = 0;
            double z = 0;
            if ((a > -3) && (a < 5))
            {
                x = a;

            }

            if ((b > -3) && (b < 5))
            {
                y = b;
            }
            if ((c > -3) && (c < 5))
            {
                z = c;
            }
            if (x != 0 && y != 0 && z != 0)
            {
                return x + " " + y + " " + z;
            }
            if (x != 0 && y != 0 && z == 0)
            {
                return x + " " + y;
            }
            if (x == 0 && y != 0 && z != 0)
            {
                return y + " " + z;
            }
            if (x != 0 && y == 0 && z != 0)
            {
                Console.WriteLine(x + " " + z);
            }
            if (x == 0 && y == 0 && z != 0)
            {
                return Convert.ToString(z);
            }
            if (x != 0 && y == 0 && z == 0)
            {
                return Convert.ToString(x);
            }
            if (x == 0 && y != 0 && z == 0)
            {
                return Convert.ToString(y);
            }
            else return "Введенные значения находятся за пределами интервала (-3;5)";
        }
    }
}
