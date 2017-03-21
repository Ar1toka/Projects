using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream FS = new FileStream(@"E:\\PR32.txt", FileMode.Append, FileAccess.Write);
            StreamWriter SW = new StreamWriter(FS);
            //string a = "";
           
            Man[] pr32 = new Man[2];
            for(int i = 0;i<pr32.Length;i++)
            {
                
                pr32[i] = new Man();
                Console.WriteLine("Введите имя: ");
                pr32[i].Name=Console.ReadLine();
                Console.WriteLine("Введите фамилию: ");
                pr32[i].SName=Console.ReadLine();
                SW.WriteLine(pr32[i].TellMe());
              
            Console.WriteLine(pr32[i].TellMe());
            }
            SW.Close();
            Console.ReadKey();
        }
        public class Man
        {
            public string Name;
            public string SName;
            public Man()
            {
                this.Name = " ";
                this.SName = " ";
            }
            public Man(string Name, string SName)
            {
                this.Name = Name;
                this.SName = SName;
            }
            public string TellMe()
            {
                return (" " + this.Name + " " + this.SName);
            }
        }
    }
}
