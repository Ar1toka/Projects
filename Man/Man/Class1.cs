using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Man
{
    public class Man
    {
        public string Name;
        public string SName;
        private int MName;
    
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

        public string sName
        {
            get
            {
                return SName;
            }
            set
            {
                SName = value;
            }
        }
    
        public string TellMe()
        {
            return (" " + this.Name + " " + this.SName);
        }
    }
}
