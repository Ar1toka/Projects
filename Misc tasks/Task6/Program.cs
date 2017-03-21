using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class DateClassProgram
    {

        static void Main()
        {

            Date dateMoonWalk = new Date(1985,10,15);

            

            Console.WriteLine("Moon walk: {0}/{1}/{2} Day of Year:{3}", dateMoonWalk.iMonth, dateMoonWalk.iDay, dateMoonWalk.iYear, dateMoonWalk.DayOfYear());
            Console.WriteLine(dateMoonWalk.ToString()); 
            Console.ReadLine();
        }

    }

    class Date
    {

        public int iYear; public int iMonth; public int iDay;

        public Date(int iYear, int iMonth, int iDay)
        {

            this.iYear = iYear; this.iMonth = iMonth; this.iDay = iDay;
        }

        public Date()
        {

            this.iYear = 1; this.iMonth = 1; this.iDay = 1;
        }


        public static bool IsLeapYear(int iYear)
        {

            return iYear % 4 == 0 && (iYear % 100 != 0 || iYear % 400 == 0);

        }

        static string[] astrMonths = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        
        static int[] aiCumulativeDays = { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334 };
        
        public override string ToString()
        {

            return String.Format("{0:G} {1:G} {2:G}", iDay, astrMonths[iMonth - 1], iYear);
        }



        public int DayOfYear()
        {

            return aiCumulativeDays[iMonth - 1] + iDay + (iMonth > 2 && IsLeapYear(iYear) ? 1 : 0);
        }

    }

}



