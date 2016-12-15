using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите X");
            string x = Console.ReadLine();
            Console.WriteLine("Введите Y");
            string y = Console.ReadLine();
            //string cx3 = "-3";
            //string cx4 = "-14";
            //string cx5 = "100";
            //// y
            //string cy1 = "7";
            //string cy2 = "1000";
            //string cy3 = "452";
            //string cy4 = "42";
            //string cy5 = "78";
            //    Console.WriteLine("INSERT INTO points (x, y) VALUES ('"+cx1+"', '"+cy1+"');");
            //    Console.WriteLine("INSERT INTO points (x, y) VALUES ('" + cx2 + "', '" + cy2 + "');");
            //    Console.WriteLine("INSERT INTO points (x, y) VALUES ('" + cx3 + "', '" + cy3 + "');");
            //    Console.WriteLine("INSERT INTO points (x, y) VALUES ('" + cx4 + "', '" + cy4 + "');");
                Console.WriteLine("INSERT INTO points (x, y) VALUES ('" + x + "', '" + y + "');");
            Console.ReadLine();
        }
    }
}
