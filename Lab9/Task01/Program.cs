using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            FileStream FS = new FileStream(@"E:\\9\Task1\test1.txt",FileMode.Open,FileAccess.Read);

            StreamReader SR = new StreamReader(FS);
            while (!SR.EndOfStream)
            {
                a=a+", "+SR.ReadLine();
                
            }
            a=a.Remove(0, 2);
            Console.Write(a);
            //Console.Write(SR.ReadToEnd());
            SR.Close();
            Console.ReadLine();
        }
    }
}
