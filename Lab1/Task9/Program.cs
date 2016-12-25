using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            string a =Console.ReadLine();
            string b = Task9(a);
                //Console.WriteLine("SELECT first_name, last_name, group FROM students WHERE student_id = '"+a+"'");
                //string b = "fa93f";
                //Console.WriteLine("SELECT first_name, last_name, group FROM students WHERE student_id = '" + b + "'");
                //string c = "42244fgh44";
                //Console.WriteLine("SELECT first_name, last_name, group FROM students WHERE student_id = '" + c + "'");
                //string d = "ertg67";
                //Console.WriteLine("SELECT first_name, last_name, group FROM students WHERE student_id = '" + d + "'");
                //string e = "343gf45";
                Console.WriteLine(b);
                Console.WriteLine(Task9("fa93f"));
                Console.WriteLine(Task9("42244fgh44"));
                Console.WriteLine(Task9("ertg67"));
                Console.WriteLine(Task9("343gf45"));
            Console.ReadLine();
        }
        public static string Task9(string a)
        {
            return "SELECT first_name, last_name, group FROM students WHERE student_id = '" + a + "'";
        }
    }
}
