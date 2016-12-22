using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
        beginning:
            Console.Write("Введите значение A: ");
            int a = int.Parse(Console.ReadLine());
            if (a < -10 || a > 100)
            {
                Console.WriteLine("Число должно быть в интервале от -10 до 100");
                goto beginning;
            }
            if ((a > 10) && (a < 20))
                Console.WriteLine(a + "'ый");
            if (a == 40)
                    Console.WriteLine(a + "'ой");
            else
            {
                int ost;
                ost = Math.Abs(a) % 10;
                switch (ost)
                {
                    case 0:
                        Console.WriteLine(a + "'ый");
                        break;
                    case 1:
                        Console.WriteLine(a + "'ый");
                        break;
                    case 2:
                        Console.WriteLine(a + "'ой");
                        break;
                    case 3:
                        Console.WriteLine(a + "'ий");
                        break;
                    case 4:
                        Console.WriteLine(a + "'ый");
                        break;
                    case 5:
                        Console.WriteLine(a + "'ый");
                        break;
                    case 6:
                        Console.WriteLine(a + "'ой");
                        break;
                    case 7:
                        Console.WriteLine(a + "'ой");
                        break;
                    case 8:
                        Console.WriteLine(a + "'ой");
                        break;
                    case 9:
                        Console.WriteLine(a + "'ый");
                        break;
                    case 10:
                        Console.WriteLine(a + "'ый");
                        break;
                }
            }
            goto beginning;
            //Console.ReadLine();
        }
    }
}
