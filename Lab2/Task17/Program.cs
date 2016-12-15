using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите скорость первого автомобиля: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите скорость второго автомобиля: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите расстояние в километрах: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Автомобили встретятся через = " +string.Format("{0:F4}",( (c/(a+b))))+" мин");
            Console.ReadLine();
        }
    }
}
