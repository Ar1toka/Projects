using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    public class clsPoint2D

{

public int x;

public int y;

//конструктор без параметров

public clsPoint2D ()

{

this.x = 1;

this.y = 1;

}

//конструктор с параметрами

public clsPoint2D (int x, int y)

{

this.x = x;

this.y = y;

}

public int length()

{
    return (Math.Abs(this.x) + Math.Abs(this.y));

}

}


}
