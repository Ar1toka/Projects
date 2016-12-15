using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра куба: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Объем куба = " + a * a * a);
            Console.ReadLine();
        }
    }
}
