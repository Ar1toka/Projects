using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c= 0;
            Console.WriteLine("Введите значение стороны А: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение стороны B: ");
            b = int.Parse(Console.ReadLine());
            c = Plo(a, b);
            Console.WriteLine("Площадь прямоугольника = "+c);
            Console.ReadLine();
        }
        public static int Plo(int a,int b)
        {
            int x = a * b;
            return x;
        }
    }
}
