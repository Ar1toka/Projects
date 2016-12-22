using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            beginning:
            Console.Write("Введите четырёхзначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if ((a < 1000) || (a>9999))
            {
                Console.WriteLine("Вы ввели не четырёхзначное число!!!");
                goto beginning;
            }
            int b = a % 10;
            int c = a / 100;
            int d = c % 10;
            if (d==b)
                Console.WriteLine("равно");
            else
                Console.WriteLine("не равно");
            Console.ReadLine();
        }
    }
}
