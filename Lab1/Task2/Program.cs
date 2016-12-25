using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Мы стремимся к ";
            string str;
            str = Console.ReadLine();
            string b = Task2(a, str);

            Console.WriteLine(b);
            Console.WriteLine(Task2(a, "знаниям"));
            Console.WriteLine(Task2(a, "цели"));
            Console.WriteLine(Task2(a, "результату"));
            Console.WriteLine(Task2(a, "власти"));
            Console.WriteLine(Task2(a, "богатству"));
            Console.WriteLine(Task2(a, "мечте"));

            Console.ReadLine();
        }
        public static string Task2(string a, string str)
        {
            return a + str;
        }
    }
}
