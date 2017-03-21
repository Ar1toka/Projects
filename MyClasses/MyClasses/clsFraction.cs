using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public delegate void DataErrorDelegat(); 
    public class clsFraction
    {
        public event DataErrorDelegat DataErrorEvent;

        private int x;
        private int y;
        private int z;
              

        public int Numerator
        {
            set
            {
                x = value;
            }
            get
            {
                return x;
            }
        }
        public int Denominator
        {
            set
            {
                if (value != 0) y = value;
                //вызов события

                else DataErrorEvent();
            }
            get
            {
                return y;
            }
        }
        public int Number
        {
            set
            {
                z = value;
            }
            get
            {
                return z;
            }
        }
        public void See(clsFraction obj)
        {
            x = x * obj.Denominator + y * obj.Numerator; y = y * obj.Denominator;
        }
        public void Mult(clsFraction obj)
        {
            x = x * obj.Numerator;
            y = y * obj.Denominator;
        }
        public void Div(clsFraction obj)
        {
            x = x * obj.Denominator;
            y = y * obj.Numerator;
        }

        public void NumMult(clsFraction obj)
        {
            x = (x * obj.Denominator)*obj.Number;
            y = (y * obj.Numerator)*obj.Number;
        }
        

    }

}
