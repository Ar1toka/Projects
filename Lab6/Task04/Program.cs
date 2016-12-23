using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
        beginning:
            Console.Write("Введите значение A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение B: ");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Значение А не может превышать значение В");
                goto beginning;
            }
            for (int i = b; i > a -1 ; i--)
                Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
