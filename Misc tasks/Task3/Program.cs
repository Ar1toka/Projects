using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
                string c = "";
            Console.WriteLine("Введите значение А: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение B: ");
            b = int.Parse(Console.ReadLine());
            c = Plo(a, b);
            Console.WriteLine("Значение А "+  c+ " значения(ю) В");
            Console.ReadLine();
        }
        public static string Plo(int a, int b)
        {
            if (a > b)
            {
                string x = ">";
                return x;
            }
            if (a < b)
            {
                string x = "<";
                return x;
            }
            else 
            {
                string x = "=";
                return x;
            }
        }
    }
}
