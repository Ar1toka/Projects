using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22
{
    class Interval
    {
        public double beginning;
        public double end;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение A1: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение B1: ");
            double b1 = double.Parse(Console.ReadLine());

            while (b1 < a1)
            {
                Console.WriteLine("Значение А1 должно быть меньше значения В1");
                Console.WriteLine("Введите значение A1: ");
                a1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение B1: ");
                b1 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите значение A2: ");
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("Введите значение B2: ");
            double b2 = double.Parse(Console.ReadLine());
            while (b2 < a2)
            {
                Console.WriteLine("Значение А2 должно быть меньше значения В2");
                Console.WriteLine("Введите значение A2: ");
                a2 = double.Parse(Console.ReadLine());
                Console.Write("Введите значение B2: ");
                b2 = double.Parse(Console.ReadLine());
            }
            string x = Task22(a1, b1, a2, b2);
            Console.WriteLine(x);
            Console.WriteLine(Task22(2, 3, 5, 7));
            Console.WriteLine(Task22(11, 17, 13, 19));
            Console.WriteLine(Task22(23, 37, 29, 31));
            Console.WriteLine(Task22(43, 53, 41, 47));
            Console.WriteLine(Task22(5, 15, 0, 30));
            Console.WriteLine(Task22(67, 71, 59, 61));
            Interval r = task22Obj(43, 53, 41, 47);
             Console.WriteLine("("+r.beginning+";"+r.end+")");
            Console.ReadLine();
        }
        public static string Task22(double a1, double b1, double a2, double b2)
        {
            if (a1 > b2 || b1 < a2)
            {
                return "не пересекаются";
            }
            if (a2 >= a1 && b2 >= b1)
            {
                return "(" + a2 + ";" + b1 + ")";
            }
            if (a1 >= a2 && b1 >= b2)
            {
                return "(" + a1 + ";" + b2 + ")";
            }
            if (a2 >= a1 && b1 >= b2)
            {
                return "(" + a2 + ";" + b2 + ")";
            }
            if (a1 >= a2 && b1 <= b2)
            {
                return "(" + a1 + ";" + b1 + ")";
            }
            if (a1 == a2 && b1 == b2)
            {
                return "(" + a1 + ";" + b1 + ")";
            }
            return "oops!";
        }
        public static Interval task22Obj(double a1, double b1, double a2, double b2)
        {
            if (a1 > b2 || b1 < a2)
            {
                return null;
            }
            if (a2 >= a1 && b2 >= b1)
            {
                Interval result = new Interval();
                result.beginning = a2;
                result.end = b1;
                return result;
            }
            if (a1 >= a2 && b1 >= b2)
            {
                Interval result = new Interval();
                result.beginning = a1;
                result.end = b2;
                return result;
            }
            if (a2 >= a1 && b1 >= b2)
            {
                Interval result = new Interval();
                result.beginning = a2;
                result.end = b2;
                return result;
            }
            if (a1 >= a2 && b1 <= b2)
            {
                Interval result = new Interval();
                result.beginning = a1;
                result.end = b1;
                return result;
            }
            if (a1 == a2 && b1 == b2)
            {
                Interval result = new Interval();
                result.beginning = a1;
                result.end = b1;
                return result;
            }
            return null;

        }
    }
}
