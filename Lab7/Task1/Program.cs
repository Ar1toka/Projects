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
            string source = "abcdefwxyz";
            Console.WriteLine("Введите значение S(из представленных букв - abcdefwxyz): ");
            string s = Console.ReadLine();
            int index = source.IndexOf(s);
            while (index == -1)
            {
                Console.WriteLine("Вы ввели неверный символ!");
                Console.WriteLine("Введите значение S(из представленных букв - abcdefwxyz): ");
                s = Console.ReadLine();
                index = source.IndexOf(s);
            }
            //char[] y1 = "abcdefwxyz".ToCharArray();
            
             
             char[] y1 = source.ToCharArray();
             int a = y1.Length;
           int b = a-index-1;
           Console.WriteLine("Количество букв после введенной вами: "+ b);
           Console.ReadLine();
        }
    }
}
