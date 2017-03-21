using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] A = new int[n];
            Random R = new Random();
            for (int i = 0; i < n; i++)
            {
                A[i] = R.Next(20);
                Console.Write(" " + A[i].ToString());
            }
            Console.WriteLine();
             int []B= Nechet(A);
             for (int i = 0; i < B.Length; i++)
             {
                 Console.Write (" " + B[i].ToString());
             }
            Console.ReadLine();

        }
        static int[] Nechet(int[]AA)
        {
            int[] BB = new int[AA.Length / 2];
            int j = 0;
            for (int i = 1; i < AA.Length;i=i+2 )
            {
                BB[j]=AA[i];
                j++;
            }

            return BB;      
        }
    }
}
