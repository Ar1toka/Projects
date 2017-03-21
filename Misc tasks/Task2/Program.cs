using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0, d=0;
            Console.WriteLine("Введите значение стороны А: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение стороны B: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение стороны C: ");
            c = int.Parse(Console.ReadLine());
            d = Plo(a, b, c );
            Console.WriteLine("Максимальное число = " + d);
            Console.ReadLine();
        }
        public static int Plo(int a, int b, int c)
        {
            int x = Math.Max(a, b);
            int z = Math.Max(x, c);
            return z;
        }
    }
}
