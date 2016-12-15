using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите значение скорость V1 в километрах в час: ");
            double a = double.Parse(Console.ReadLine());
            if (a<0)
            {
                Console.WriteLine("Введите положительно число", a);
                return;
            }
            Console.Write("Введите скорость V2 в метрах в секунду: ");
            double b = double.Parse(Console.ReadLine());
            if (b < 0)
            {
                Console.WriteLine("Введите положительно число", b);
                return;
            }
            double d = (b*10)/36;
            //double e = b;
            if (d > a)
            {
                Console.WriteLine("V1 (км/ч) меньше V2 (м/с)");
            }
            else
            {
                Console.WriteLine("V2 (м/с) меньше V1(км/ч)");
            }

            Console.ReadLine();
        }
    }
}
