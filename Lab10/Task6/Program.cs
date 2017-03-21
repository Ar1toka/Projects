using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 500;
            //int[] A = new int[n];
            string a = " ";
            for (int i = 1; i < 501; i++)

                a = a + " " + i.ToString();
            //File.WriteAllText(@"E:\\numbers.txt",a);
            FileStream FS = new FileStream(@"E:\\numbers.txt", FileMode.Create,FileAccess.ReadWrite);
            StreamWriter SW = new StreamWriter(FS);

            SW.Write(a);
            //Console.Write(a);
            SW.Close();
            
            Console.ReadLine();
        }
    }
}
