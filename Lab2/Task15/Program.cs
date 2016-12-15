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
            Console.Write("Введите число в градусах по Цельсию: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Температура по Кельвину: " + (a * 1.8 + 32));
            Console.ReadLine();
        }
    }
}
