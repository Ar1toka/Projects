using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task29
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            //int pro = 1;
            int a;
            do
            {
                Console.WriteLine("Введите значение A (0 - признак конца): ");
                a = int.Parse(Console.ReadLine());


                if (a % 2==0 && a!=0) Sum = Sum + 1;
                //if (a < 0) pro = pro * a;
            }
            while (a != 0);
            Console.WriteLine("Количество чётных чисел: " + Sum);
            //Console.WriteLine("Произведение отрицательных чисел: " + pro);
            Console.ReadLine();
        }
    }
}
