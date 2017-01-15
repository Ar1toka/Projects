using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение X: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            double y = double.Parse(Console.ReadLine());

            Console.Write("Введите значение A: ");
            double a = double.Parse(Console.ReadLine());
            while (a <= 0)
            {
                Console.WriteLine("Значение A должно быть больше 0");
                Console.Write("Введите значение А: ");
                a = double.Parse(Console.ReadLine());


            }
            Console.Write("Введите значение L: ");
            double l = double.Parse(Console.ReadLine());
            while (l <= (a/2))
            {
                Console.WriteLine("Значение L должно быть больше 0");
                Console.Write("Введите значение L: ");
                l = double.Parse(Console.ReadLine());

            }
            string c = Task3(x, y, a, l);
            Console.WriteLine(c);
            Console.WriteLine(Task3(5, 5, 500, 300));
            Console.WriteLine(Task3(300, 20, 20, 200));
            Console.WriteLine(Task3(100, 200, 200, 200));
            Console.WriteLine(Task3(807, 120, 200, 300));
            Console.ReadLine();




        }
        public static string Task3(double x, double y, double a, double l)
        {
            double b = y + Math.Sqrt((l * l) - ((a * a) / 4));
            double c = x + a;
            double d = x+(a/2);
            return "(" + x + ";" + y + ") (" + c + ";" + y + ") (" + d + ";" + Math.Round(b,4) + ")";

        }
    }
}
