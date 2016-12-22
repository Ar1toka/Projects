using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.Write("Введите значение X: ");
            double x = double.Parse(Console.ReadLine());
                 
            Console.Write("Введите значение Y: ");
            double y = double.Parse(Console.ReadLine());

            Console.Write("Введите значение Z: ");
            double z = double.Parse(Console.ReadLine());
            
            double a = 0;
            double b = 0;
            double c = 0;

            if (x >= 0)
            {
               a = x*x;
            }
            if (x < 0)
            {
                a = x;
            }
            if (y >= 0)
            {
             b = y * y;
            }
            if (y < 0)
            {
             b = y;
            } if (z >= 0)
            {
            c = z * z;
            }
            if (z < 0)
            {
            c = z;
            }
            Console.WriteLine("Результаты вычислений: " + a + ";" + b + ";" + c);

            Console.ReadLine();
        }
    }
}
