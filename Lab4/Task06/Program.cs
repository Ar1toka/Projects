using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение H: ");
            double h = double.Parse(Console.ReadLine());
            while (h < 0 || h >=24)
            {
                Console.WriteLine("Значение H должно быть больше 0, но меньше 24");
                Console.Write("Введите значение H: ");
                h = double.Parse(Console.ReadLine());


            }
            Console.Write("Введите значение M: ");
            double m = double.Parse(Console.ReadLine());
            while (m < 0 || m > 59)
            {
                Console.WriteLine("Значение M должно быть больше 0, но меньше 60");
                Console.Write("Введите значение M: ");
                m = double.Parse(Console.ReadLine());


            }
            Console.Write("Введите значение S: ");
            double s = double.Parse(Console.ReadLine());
            while (s < 0 || s>59)
            {
                Console.WriteLine("Значение S должно быть больше 0, но меньше 60");
                Console.Write("Введите значение S: ");
                s = double.Parse(Console.ReadLine());
        }
            double b = Task6(h,m,s);
            Console.WriteLine(b);
            Console.WriteLine(Task6(0,	0	,0));
            Console.WriteLine(Task6(6	,0,	0));
            Console.WriteLine(Task6(15,	0,	0));
            Console.WriteLine(Task6(3,	30,	0));
            Console.WriteLine(Task6(21	,0,	17));

            Console.ReadLine();

        }
        public static double Task6(double h, double m, double s)
        {
            double a = ((h/12)*3600+m*60+s)/12/3600*360;
            return Math.Round(a,3);
        }
    }
            
    
}
