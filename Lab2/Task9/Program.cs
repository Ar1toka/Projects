using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите угол в градусах: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int d = a % 360;
            Console.WriteLine("Резултат вычислений = " + d);
            Console.ReadLine();
        }
    }
}
