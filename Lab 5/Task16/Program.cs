using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение M: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение P: ");
            double b = double.Parse(Console.ReadLine());

            double x = a / b;
            if ((x % 1) == 0)

                Console.WriteLine("Результат деления: " + x);
            else
                Console.WriteLine("M не делится нацело на P");
            Console.ReadLine();
        }
    }
}
