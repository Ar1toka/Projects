using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Программирование это ";
            //string b = "просто"
            //string c = "интересно"
            //string d = "перспективно"
            //string e = "забавно"
            //string f = "увлекательно"
            //string g = "супер"
            string c = "!";
            string b;
            
            b = Console.ReadLine();
            string d = Task4(a, b, c);
            Console.WriteLine(d);
            Console.WriteLine(Task4(a, "просто", c));
            Console.WriteLine(Task4(a, "интересно", c));
            Console.WriteLine(Task4(a, "перспективно", c));
            Console.WriteLine(Task4(a, "забавно", c));
            Console.WriteLine(Task4(a, "увлекательно", c));
            Console.WriteLine(Task4(a, "супер", c));
            Console.ReadLine();
        }
        public static string Task4(string a, string b, string c)
        {
            return a + b + c;
        }
    }
}
