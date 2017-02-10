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
            string source = "abcdefwxyz";
            Console.WriteLine("Введите строку(из представленных букв - abcdefwxyz): ");
            string s = Console.ReadLine();

             int index = source.IndexOf(s);
            if (index!=-1)
            Console.WriteLine("Содержится");
             else
                Console.WriteLine("Не содержится");
            Console.ReadLine();
        }
    }
}
