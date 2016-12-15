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
            Console.Write("Введите число: ");
            string num = Console.ReadLine();
            if (num.Length !=2 )
            {
                Console.WriteLine("В числе {0} не три цифры.", num);
            }
            else
            {
                int arg1 = int.Parse(num[0].ToString());
                int arg2 = int.Parse(num[1].ToString());
                //int arg3 = int.Parse(num[2].ToString());

                //arg1 = arg2 + arg1;
                //arg3 = arg1 - arg3;
                //arg1 = arg1 - arg3;

                Console.WriteLine("Исходное число {0}", num);
                num = arg2.ToString() +arg1.ToString(); // + arg3.ToString();
                Console.WriteLine("Преобразованное число {0}", num);

            }
            Console.ReadKey();
        }
    }
}
