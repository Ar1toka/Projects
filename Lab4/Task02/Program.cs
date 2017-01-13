using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение Xэц: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Введите значение Yэц: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Введите значение Xмт: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Введите значение Yмт: ");
            double y2 = double.Parse(Console.ReadLine());

            string c = Task2(x1, y1, x2, y2);
            Console.WriteLine(c);
            Console.WriteLine(Task2(400, 500, 60, 70));
            Console.WriteLine(Task2(11, 13, 713, -86));
            Console.WriteLine(Task2(691, 584, -462, 359));
            Console.ReadLine();

        }
        public static string Task2(double x1, double y1, double x2, double y2)
        {
            double a = x1 + x2;
            double b = y1 - y2;
            return "(" + a + ";" + b + ")";
        }
    }
}
