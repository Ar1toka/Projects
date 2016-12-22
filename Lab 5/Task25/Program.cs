using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            beginning:
            Console.Write("Введите значение W: ");
            int w = int.Parse(Console.ReadLine());
            Console.Write("Введите значение H: ");
            int h = int.Parse(Console.ReadLine());
            beginning2:
            Console.Write("Введите значение C: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Введите значение D: ");
            int d = int.Parse(Console.ReadLine());
            if ((w < c) || (w < d) || (h < c ) || (h < d))
            {
                Console.WriteLine("Значения W и H не могут быть меньше значений C и D");
                goto beginning;
            }
            if (c<d)
            {
                Console.WriteLine("Значение С не может быть меньше D");
                goto beginning2;
            }
            int a = h / c;
            int b = w / c;
            int e = h / d;
            int f = w / d;

            int g = a * f;
            int i = b * e;

            if (a > b)
            {
                Console.WriteLine(g +"при C вдоль H");
            }
            else
            {
                Console.WriteLine(i + "при C вдоль W");
            }

            goto beginning;
        }
    }
}
