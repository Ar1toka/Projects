using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение A (больше единицы): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите символ B: ");
            string b = Console.ReadLine();
            while (a < 1)
            {
                Console.WriteLine("Значение неверное!");
                Console.Write("Введите значение A(больше единицы): ");
                a = int.Parse(Console.ReadLine());
            }
            Console.Write("\"");
            for (int i = 0; i < a; i++)
            {
                Console.Write(b, i);
            }
            Console.Write("\"");
            Console.ReadLine();
        }
    }
}
