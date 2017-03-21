using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            int m = 0, n = 0;
            double S = 0.0, D = 0.0;
            FileStream FS = new FileStream(@"E:\\9\Task2\test3.txt", FileMode.Open, FileAccess.Read);

            StreamReader SR = new StreamReader(FS);
            //while (!SR.EndOfStream)
            //{
            //    a = a + ", " + SR.ReadLine();

            //}
            //a = a.Remove(0, 2);
            a = SR.ReadLine();
            m = int.Parse(a);
            Console.WriteLine(m);
            for (int i = 0; i < m;i++)
            {
                a = SR.ReadLine();
                n = int.Parse(a);
                if (n < 20)
                {
                    S = S + n;
                }
            }

                
            //Console.Write(SR.ReadToEnd());
            SR.Close();
            D = S / m;
            Console.Write(D);
            Console.ReadLine();
        }
    }
}
