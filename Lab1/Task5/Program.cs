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
            string a;
            string b;
            a = Console.ReadLine();
            b = Console.ReadLine();
            string c = Task5(b, a);
            //string b = "знание"
            //string c = "яйцо"
            //string d = "шаг"
            //string e = "ходьба"
            //string f = "обезьяна"
            //string g = "вода"

            //string h = " начало";
            //string i = "сила"
            //string j = "курица"
            //string k = "шаг"
            //string l = "бег"
            //string m = "человек"
            //string n = "жизнь"
            Console.WriteLine(c);
            Console.WriteLine(Task5("знание", "сила"));
            Console.WriteLine(Task5("яйцо", "курица"));
            Console.WriteLine(Task5("шаг", "шаг"));
            Console.WriteLine(Task5("ходьба", "бег"));
            Console.WriteLine(Task5("обезьяна", "человек"));
            Console.WriteLine(Task5("вода", "жизнь"));
            Console.ReadLine();
        }
        public static string Task5(string b, string a)
        {
            return b + " " + a;
        }
    }
}
