using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите значение C: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Введите значение D: ");
            double d = double.Parse(Console.ReadLine());

            if ((a<c)&&(b<d))

                Console.WriteLine("Размещение возможно");
            else
                Console.WriteLine("Размещение невозможно");

            Console.ReadLine();
        }
    }
}
