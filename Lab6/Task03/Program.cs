using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите значение A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение B: ");
            int b = int.Parse(Console.ReadLine());
            while (a>b)
            {
                Console.WriteLine("Значение А не может превышать значение В");
                Console.Write("Введите значение A: ");
                a = int.Parse(Console.ReadLine());
            }
                for (int i = a; i < b+1; i++)
                Console.WriteLine(i);
            Console.ReadLine();

        }
    }
}
