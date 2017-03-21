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
            Console.WriteLine("Введите строку, разделяя слова запятыми: ");
            string a = Console.ReadLine();
            int index = a.IndexOf(",,");
            int index2 = a.LastIndexOf(",");
            int index3 = a.IndexOf(",");
            int b = a.Length-index2-1;
            while (index!=-1 || b == 0 || index3==0)
            {
                Console.WriteLine("Вы что-то намудрили!");
                Console.WriteLine("Введите строку, разделяя слова запятыми: ");
                a = Console.ReadLine();
                index = a.IndexOf(",,");
                index2 = a.LastIndexOf(",");
                index3 = a.IndexOf(",");
                b = a.Length - index2;
            }
            string text = a;

            string[] words = text.Split(new char[] { ',' });
            //int c = 0;
            //foreach (string s in words)
            //{
            //    c++;
            //}
            Console.WriteLine("Количество слов: " + words.Length);
            Console.ReadLine();
        }
    }
}
