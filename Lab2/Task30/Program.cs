using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат вычислений = " + string.Format("{0:F4}", ((Math.Sin(Math.PI * a / 180)*Math.Cos(Math.PI * b / 180))+((Math.Cos(Math.PI * a / 180)*(Math.Sin(Math.PI * b / 180)))))));
            Console.ReadLine();
        }
    }
}
