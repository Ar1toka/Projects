using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
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
           
            if ((c == b) || (b == a) || (c==a))
            {
                Console.WriteLine("Среди чисел есть равные");
            }
            else
            {
                Console.WriteLine("Числа не равны друг другу.");
            }

            Console.ReadLine();
        
        }
    }
}
