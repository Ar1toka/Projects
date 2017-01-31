using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task30
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c = 1;
            int d = 0;
            int e = 1;
            int f =0;
            int g = 0;
            Console.WriteLine("Введите значение A (0 - признак конца): ");
            b = int.Parse(Console.ReadLine());
            do
            {
               
                Console.WriteLine("Введите значение A (0 - признак конца): ");
                a = int.Parse(Console.ReadLine());
                c = c + 1;
                if (a > b && a != 0)
                {
                    b = a;
                    d = c;
                }
                if (a<0 && a!=0)
                { e = e + 1;
                f = a;
                }
                if (e == 2) g = f;
            }
            while (a != 0);
            Console.WriteLine("Максимальное число: " + b);
            Console.WriteLine("По счёту: " + d);
            Console.WriteLine("Pyfxtybt dnjhjuj ytxtnyjuj: " + g);
 

            Console.ReadLine();
        }
    }
}
