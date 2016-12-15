using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ваше число, округленное до 4 знаков после запятой: " + string.Format("{0:F4}", a));
            Console.ReadLine();
        }
    }
}
