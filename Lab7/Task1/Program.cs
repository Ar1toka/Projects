using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение S(из представленных букв - abcdefwxyz): ");
            string s = Console.ReadLine();
            //char[] y1 = "abcdefwxyz".ToCharArray();
            string source = "abcdefwxyz";
             int index = source.IndexOf(s);
             char[] y1 = source.ToCharArray();
             int a = y1.Length;
           int b = a-index-1;
           Console.WriteLine("Количество букв после введенной вами: "+ b);
           Console.ReadLine();
        }
    }
}
