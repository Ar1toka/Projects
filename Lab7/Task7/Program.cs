using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = "abcdacadbacdaabaadc";
            Console.WriteLine("Введите комбинацию из 2х букв(из представленных букв - abcdacadbacdaabaadc): ");
            string s = Console.ReadLine();

            int index = source.IndexOf(s);
            while (index == -1)
            {
                Console.WriteLine("Увы, ничего не вышло");
                Console.WriteLine("Введите значение S(из представленных букв - abcdefwxyz): ");
                s = Console.ReadLine();
                index = source.IndexOf(s);
            }
            source = source.Replace(s, " ");
            Console.WriteLine(source);
            Console.ReadLine();
        }
    }
}
