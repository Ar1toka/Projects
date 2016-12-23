using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Result
    {
        public int quantity;
        public int remainder;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину рулона в метрах: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длину материала в сантиметрах необходимую для изготовления изделия: ");
            int b = Convert.ToInt32(Console.ReadLine());
            string e = task8(a, b);
            Console.WriteLine(e);

            Result r = task8Obj(400, 17);
            Console.WriteLine("Количество изделий = " + r.quantity + " Остаток: " + r.remainder + "см");
            Console.ReadLine();
        }
        public static string task8(int a, int b)
        {
            int c = a * 100;
            int d = c % b;
            return "Количество изделий = " + c / b + " Остаток: " + d + "см";
        }

        public static Result task8Obj(int a, int b)
        {
            int c = a * 100;
            int d = c % b;
            Result result = new Result();
            result.quantity = c / b;
            result.remainder = d;
            return result;
        }

    }
}
