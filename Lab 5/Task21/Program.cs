using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение Хт: ");
            double xt = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Yт: ");
            double yt = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Хп1: ");
            double xp1 = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Yп1: ");
            double yp1 = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Хп2: ");
            double xp2 = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Хп2: ");
            double yp2 = double.Parse(Console.ReadLine());

            if ((yt - yp1) / (yp2 - yp1) == (xt - xp1) / (xp2 - xp1)) 
                Console.WriteLine("точка принадлежит прямой");
            else 
                Console.WriteLine("точка не принадлежит прямой");
            Console.ReadLine();
        }
    }
}
