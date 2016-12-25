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
            string a = " нас не остановят!";
            //string b = "трудности"
            //string c = "загадки"
            //string d = "сложные задачи"
            //string e = "враги"
            //string f = "баги"
            //string g = "фэйлы"
            //Console.WriteLine(b + a);
            //Console.WriteLine(c + a);
            //Console.WriteLine(d + a);
            //Console.WriteLine(e + a);
            //Console.WriteLine(f + a);
            //Console.WriteLine(g + a);
            string b;
            b = Console.ReadLine();
            String c = Task3(b, a);
            Console.WriteLine(c);
            Console.WriteLine(Task3("трудности", a));
            Console.WriteLine(Task3("загадки", a));
            Console.WriteLine(Task3("сложные задачи", a));
            Console.WriteLine(Task3("враги", a));
            Console.WriteLine(Task3("баги", a));
            Console.WriteLine(Task3("фэйлы", a));
            Console.ReadLine();
        }
        public static string Task3(string b, string a)
        {
            return b + a;
        }
    }
}
