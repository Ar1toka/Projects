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
            int k = 1;
            int a = 0;
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
            for (int i = 0; i < n; i++)
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
            }
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < n; ++i)
                Console.Write("\t" + aiC[i]);
            Console.WriteLine();
 


 
            for (int i = 0; i < k; ++i)
            {
              int aLast = aiC[n-1];
              for (int j = n-1; j>0; j--)
                  aiC[j] = aiC[j-1];
              aiC[0] = aLast;
            }
 
            Console.WriteLine("Новый массив: ");
            for (int i = 0; i < n; ++i)
                Console.Write("\t" + aiC[i]);
            Console.WriteLine();
            Console.ReadKey();

            Console.ReadLine();
        }

    }
}
