using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 3;
            const int m = 3;
            int[,] A = new int[n, m];
            Random R = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = R.Next(20);
                    Console.Write("\t " + A[i, j]);



                }
                Console.WriteLine();


            }
            Console.WriteLine();
            int zam = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    zam = A[i, j];
                    A[i, j] = A[j, i];
                    A[j, i] = zam;

                }
                Console.WriteLine();

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("\t " + A[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
