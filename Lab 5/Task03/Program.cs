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

            Console.Write("Введите число K: ");
            int input_a = int.Parse(Console.ReadLine());
            double b = task3(input_a);
            Console.WriteLine("Результат вычислений " + b);

            Console.WriteLine("Результат вычислений " + task3(9));
            Console.WriteLine("Результат вычислений " + task3(0));
            Console.WriteLine("Результат вычислений " + task3(-7));

            Console.ReadLine();
        }
        public static double task3(int a)
        {
            if (a > 0)
            {
                return Math.Sqrt(a);
            }
            else
            {
                return a * a;
            }
        }
    }
}
