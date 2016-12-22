using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task24
{
    class Program
    {
        static void Main(string[] args)
        {
        beginning:
            Console.Write("Введите значение A: ");
            int a = int.Parse(Console.ReadLine());
            if (a < 1 || a > 60)
            {
                Console.WriteLine("Число должно быть в интервале от 1 до 60");
                goto beginning;
            }
            
                int ost;
                ost = Math.Abs(a) % 10;
                switch (ost)
                {

                    case 1:
                        Console.WriteLine("Зеленый");
                        break;
                    case 2:
                        Console.WriteLine("Зеленый");
                        break;
                    case 3:
                        Console.WriteLine("Зеленый");
                        break;
                    case 4:
                        Console.WriteLine("Красный");
                        break;
                    case 5:
                        Console.WriteLine("Красный");
                        break;
                    case 6:
                        Console.WriteLine("Зеленый");
                        break;
                    case 7:
                        Console.WriteLine("Зеленый");
                        break;
                    case 8:
                        Console.WriteLine("Зеленый");
                        break;
                    case 9:
                        Console.WriteLine("Красный");
                        break;
                    case 10:
                        Console.WriteLine("Красный");
                        break;
                }
            
            goto beginning;
        }
    }
}
