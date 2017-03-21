using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle X = new Rectangle();
            Console.WriteLine("Введите значение стороны А: ");
            X.a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение стороны B: ");
            X.b = int.Parse(Console.ReadLine());
            Console.WriteLine("Площадь прямоугольника равна "+X.Plo());
            Console.WriteLine("Диагональ прямоугольника равна "+Math.Round(X.Diag(),4));
            Console.ReadLine();
        }
        public class Rectangle
        {
            public int a;
            public int b;
            public int Plo()
            {
                return a * b;
            }
            public double Diag()
            {
                return Math.Sqrt((a*a)+(b*b));
            }
        }
    }
}
