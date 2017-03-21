using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            double b = 0;
            double min = 0;
            double kol = 0;
            string path = @"E:\\9\Task3\test5.txt";
            FileStream FS = new FileStream(path, FileMode.Open, FileAccess.Read);

            StreamReader SR = new StreamReader(FS);
            a = SR.ReadLine();
            b = double.Parse(a);
            min = b;
            //Console.WriteLine(min);
            while (!SR.EndOfStream)
            {
                a =SR.ReadLine();
                b = double.Parse(a);
                if (b<min)
                {
                    min = b;
                }

            }


            //Console.Write(SR.ReadToEnd());
            SR.Close();
            FS = new FileStream(path, FileMode.Open, FileAccess.Read);

            SR = new StreamReader(FS);
            while (!SR.EndOfStream)
            {
                a = SR.ReadLine();
                b = double.Parse(a);
                if (b == min)
                {
                    kol++;
                }

            }
            Console.WriteLine(kol);
            Console.ReadLine();
        }
    }
}
