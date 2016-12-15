using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите двузначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int d = a % 10;
            Console.WriteLine("Результат вычислений = " + d);
            Console.ReadLine();
        }
    }
}
