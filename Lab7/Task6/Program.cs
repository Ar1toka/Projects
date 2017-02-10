using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            int result2;
            string a;
            string source = "s";
            string source2 = "U";
            Console.WriteLine("Введите строку(начиная с s или U): ");
            string s = Console.ReadLine();
            a = s.Remove(1, s.Length-1);
            result = String.Compare(a, source);
            result2 = String.Compare(a, source2);
            while (result!=0 && result2!=0)
            {
                Console.WriteLine("Начальным символом не являлись ни s, ни U.");
                Console.WriteLine("Введите строку(начиная с s или U): ");
                s = Console.ReadLine();
                a = s.Remove(1, s.Length - 1);
                result = String.Compare(a, source);
                result2 = String.Compare(a, source2);
            }
            if (result == 0)
                Console.WriteLine(s.ToLower());
            if (result2 == 0)
                Console.WriteLine(s.ToUpper());


            Console.ReadLine();
        }
    }
}
