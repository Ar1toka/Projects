using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int x=0;
            const int z = 20;
            Console.WriteLine("Введите значение N(не более 20, но не менее 1): ");
            int n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Вы ввели неверное значение N: ");
                Console.WriteLine("Введите значение N(не более 20, но не менее 1): ");
                n = int.Parse(Console.ReadLine());

            }
            int[] aiC = new int[z];
            x = aiC[n - 1];
            for (int i = n-2; i >= 0; i--)
            {
                Console.Write("Введите число от 1 до 4: ");
                a = int.Parse(Console.ReadLine());

                while (a < 1 || a > 4)
                {
                    Console.WriteLine("Вы ввели неверное число!");
                    Console.WriteLine("Введите число от 1 до 4: ");
                    a = int.Parse(Console.ReadLine());
                }
                aiC[i] = a;
                aiC[i + 1] = aiC[i];
            }
            aiC[0] = x;

            for (int i = 0; i< n; i++)
            {
                Console.Write(aiC[i]);
            }


            Console.ReadLine();
        }

    }
}
