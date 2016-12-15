using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение х1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение х2: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение х3: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат вычислений = " + ((a*b)+(a*c)+(b*c)));
            Console.ReadLine();
        }
    }
}
