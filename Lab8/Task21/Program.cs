﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            const int n = 4;
            const int m = 6;
            int[,] A = new int[n, m];
            Random R = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = R.Next(20);
                    Console.Write(" " + A[i, j]);
                    s = s + A[i, j];

                }
                //Console.WriteLine();
                Console.WriteLine( " Сумма: " + s);
            }
            //Console.WriteLine("Сумма: " + s);
            Console.ReadLine();
        }
    }
}
