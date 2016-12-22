using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            beginning:
            Console.WriteLine("Введите значение A1: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение B1: ");
            double b1 = double.Parse(Console.ReadLine());

            if (b1<a1)
            {
                Console.WriteLine("Значение А1 должно быть меньше значения В1");
                goto beginning;
            }
            Console.WriteLine("Введите значение A2: ");
            beginning2:
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("Введите значение B2: ");
            double b2 = double.Parse(Console.ReadLine());
            if (b2 < a2)
            {
                Console.WriteLine("Значение А2 должно быть меньше значения В2");
                goto beginning2;
            }
            if (a1 > b2 || b1 < a2)
            {
                Console.WriteLine("не пересекаются");
            }
            if (a2 >= a1 && b2>= b1)
            {
                Console.WriteLine("(" + a2 + ";" + b1 + ")");
            }
            if (a1 >= a2 && b1 >= b2)
            {
                    Console.WriteLine("(" + a1 + ";" + b2 + ")");
            }
            if (a2>=a1 && b1>=b2)
                    {
                        Console.WriteLine("(" + a2 + ";" + b2 + ")");
                    }
            if (a1>=a2 && b1 <= b2)
                        {
                            Console.WriteLine("(" + a1 + ";" + b1 + ")");
                        }
            if (a1==a2 && b1==b2)
            {
                Console.WriteLine("(" + a1 + ";" + b1 + ")");
            }
                            goto beginning;
            //Console.ReadLine();
        }
    }
}
