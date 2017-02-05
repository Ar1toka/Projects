using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task31
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int n = 5;
            int b = 0;
            Console.WriteLine("Введите значение A (от 0 до 10): ");
                a = int.Parse(Console.ReadLine());
            
                int []aiC=new int [n];
                Random rand = new Random();
                for (int i = 0; i < n; i++)
                {
                    aiC[i] = rand.Next(0, 10);
                    Console.WriteLine(aiC[i]);
                    if (a == aiC[i])
                    {
                        b = b + 1;
                        Console.WriteLine("Ура! " + i);
                    }
                }
            if (b == 0)
                        Console.WriteLine("Повезет в другой раз!");
                Console.ReadLine();
        }

    }
}
