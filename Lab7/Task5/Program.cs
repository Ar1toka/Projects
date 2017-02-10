using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
           //string a;
            string source = "abcdefwxyz";
            Console.WriteLine("Введите значение A(от 0 до 9): ");
            int s = int.Parse(Console.ReadLine());
            while (s <0 || s >9)
            {
                Console.WriteLine("Вы ввели неверное значение!");
                Console.WriteLine("Введите значение A (от 0 до 9): ");
s = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите значение В (от 0 до 9): ");
            int m = int.Parse(Console.ReadLine());
            while (m < 0 || s > 9)
            {
                Console.WriteLine("Вы ввели неверное значение!");
                Console.WriteLine("Введите значение В (от 0 до 9): ");
                s = int.Parse(Console.ReadLine());
            }
            //if (s == 0)
            //{
            //    source = source.Substring(m);
            //    Console.WriteLine(source);
            //}
            //if (m == 0)
            //{
            //    Console.WriteLine(source);
            //}
            //else
            //{
            //    a = source.Substring(0, source.Length - s);
            //    source = source.Substring(s);
            //    source = source.Substring(m);
            //    Console.WriteLine(a+source);
            //}
            source = source.Remove(s, m);
            Console.WriteLine(source);
            Console.ReadLine();
        }
    }
}
