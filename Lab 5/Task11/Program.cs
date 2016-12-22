using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
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
           
            if ((c > b) && (b > a))
            {
                Console.WriteLine("Выполняется");
            }
            else
            {
                Console.WriteLine("Не выполняется");
            }

            Console.ReadLine();
        }
    }
}
