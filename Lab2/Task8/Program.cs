using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину рулона в метрах: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длину материала в сантиметрах необходимую для изготовления изделия: ");
            int b = Convert.ToInt32(Console.ReadLine());
           int c = a*100;
           int d = c % b;
            Console.WriteLine("Количество изделий = " + c / b + " Остаток: " + d + "см");
            Console.ReadLine();
        }
    }
}
