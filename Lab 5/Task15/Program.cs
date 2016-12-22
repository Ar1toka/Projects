using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
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

            double x= Math.Max(a,b);
            double y = Math.Max(x,c);
           
                Console.WriteLine("Результат сравнения: "+y);
          
            Console.ReadLine();
        }
    }
}
