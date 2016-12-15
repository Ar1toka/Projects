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
            Console.Write("Введите длину ребра куба: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Площадь его боковой поверхности = "+(a * a) * 6);
            Console.ReadLine();
        }
    }
}
