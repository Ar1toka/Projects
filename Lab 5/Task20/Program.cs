using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение Хт: ");
            double xt = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Yт: ");
            double yt = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Хп: ");
            double xp = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Yп: ");
            double yp = double.Parse(Console.ReadLine());
            Console.Write("Введите значение H: ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("Введите значение W: ");
            double w = double.Parse(Console.ReadLine());

            if (((xt > xp) && (xt < w)) && ((yt>yp)&&(yt<h)))

                Console.WriteLine("точка внутри");
            else
                Console.WriteLine("точка не внутри");

            Console.ReadLine();
        }
    }
}
