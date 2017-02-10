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
            int a = 0;
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
            Console.WriteLine("Введите значение M(из представленных букв - abcdefwxyz): ");
            string m = Console.ReadLine();
            int index2 = source.IndexOf(m);
            while (index2 == -1)
            {
                Console.WriteLine("Вы ввели неверный символ!");
                Console.WriteLine("Введите значение M(из представленных букв - abcdefwxyz): ");
                m = Console.ReadLine();
                index2 = source.IndexOf(m);
            }
            //char[] y1 = source.ToCharArray();
            if (index < index2)
 
            a = index2-index-1;
            if (index > index2)
            a = index-index2-1;
            Console.WriteLine("Количество букв между введённых вами: " + a);
            Console.ReadLine();
        }
    }
}
