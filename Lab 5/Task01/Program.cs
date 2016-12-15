using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Первое");
            }
            else
            {
                Console.WriteLine("Второе");
            }

            Console.ReadLine();
            //Console.Write("Введите число: ");
            //string num = Console.ReadLine();
            //if (num.Length != 3)
            //{
            //    Console.WriteLine("В числе {0} не три цифры.", num);
            //}
            //else
            //{
            //    int arg1 = int.Parse(num[0].ToString());
            //    int arg2 = int.Parse(num[1].ToString());
            //    int arg3 = int.Parse(num[2].ToString());

            //    //arg1 = arg2 + arg1;
            //    //arg3 = arg1 - arg3;
            //    //arg1 = arg1 - arg3;

            //    Console.WriteLine("Исходное число {0}", num);
            //    num = arg3.ToString() + arg2.ToString() + arg1.ToString();
            //    Console.WriteLine("Преобразованное число {0}", num);
        }
    }
}
