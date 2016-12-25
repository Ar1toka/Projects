using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            // user
            Console.WriteLine("Введите значение user");
            string cx1 = Console.ReadLine();
            //string cx2 = "admin"   , "7e8efd48d69c" ,"production-node1","5432"     ,"bank"
            //string cx3 = "akryukov", "123"          ,"localhost"       ,"dev-node1","bank"
            //string cx4 = "756-pro" , "56"           ,"ooo-m1"          ,"4456"     ,"school"
            //string cx5 = "masha25" , "36"           ,"ntv-onp45"       ,"7946"     ,"nm-34"
            //string cx6 = "den-54"  , "986"          ,"production-n"    ,"5516"     ,"b-34-nbg"
            // pass
            Console.WriteLine("Введите значение pass");
            string cy1 = Console.ReadLine();
            //string cy2 = "7e8efd48d69c"
            //string cy3 = "123"
            //string cy4 = "56"
            //string cy5 = "36"
            //string cy6 = "986"
            // host
            Console.WriteLine("Введите значение host");
            string r1 = Console.ReadLine();
            //string r2 = "production-node1"
            //string r3 = "localhost"
            //string r4 = "ooo-m1"
            //string r5 = "ntv-onp45"
            //string r6 = "production-n"
            // port
            Console.WriteLine("Введите значение port");
            string fill1 = Console.ReadLine();
            //string fill2 = "5432"
            //string fill3 = "dev-node1"
            //string fill4 = "4456"
            //string fill5 = "7946"
            //string fill6 = "5516"
            // db
            Console.WriteLine("Введите значение db");
            string db1 = Console.ReadLine();
            //string db2 = "bank"
            //string db3 = "bank"
            //string db4 = "school"
            //string db5 = "nm-34"
            //string db6 = "b-34-nbg"
            string res = Task12(cx1, cy1, r1, fill1, db1);
            Console.WriteLine(Task12("admin", "7e8efd48d69c", "production-node1", "5432", "bank"));
            Console.WriteLine(Task12("akryukov", "123", "localhost", "dev-node1", "bank"));
            Console.WriteLine(Task12("756-pro", "56", "ooo-m1", "4456", "school"));
            Console.WriteLine(Task12("masha25", "36", "ntv-onp45", "7946", "nm-34"));
            Console.WriteLine(Task12("den-54", "986", "production-n", "5516", "b-34-nbg"));
                            //Console.WriteLine("User ID=" + cx2 + ";Password=" + cy2 + ";Host=" + r2 + ";Port=" + fill2 + ";Database=" + db2 + ";");
                //Console.WriteLine("User ID=" + cx3 + ";Password=" + cy3 + ";Host=" + r3 + ";Port=" + fill3 + ";Database=" + db3 + ";");
                //Console.WriteLine("User ID=" + cx4 + ";Password=" + cy4 + ";Host=" + r4 + ";Port=" + fill4 + ";Database=" + db4 + ";");
                //Console.WriteLine("User ID=" + cx5 + ";Password=" + cy5 + ";Host=" + r5 + ";Port=" + fill5 + ";Database=" + db5 + ";");
                //Console.WriteLine("User ID=" + cx6 + ";Password=" + cy6 + ";Host=" + r6 + ";Port=" + fill6 + ";Database=" + db6 + ";");
            Console.ReadLine();
        }
        public static string Task12(string cx1, string cy1, string r1, string fill1, string db1)
        {
            return "User ID=" + cx1 + ";Password=" + cy1 + ";Host=" + r1 + ";Port=" + fill1 + ";Database=" + db1 + ";";
        }
    }
}
