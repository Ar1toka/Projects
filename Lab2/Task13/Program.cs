using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Квадратный корень, умноженный на 3 = " + string.Format("{0:F4}",(3*Math.Sqrt(a))));
            Console.ReadLine();
        }
    }
}
