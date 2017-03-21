using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    public class clsPoint3D: clsPoint2D

{

public int z;

public clsPoint3D ():base()

{

this.z = 1;

}

public clsPoint3D (int x, int у, int z):base(x, у)

{

this.z = z;

}

public int length()

{

return (Math.Abs(base.x) + Math.Abs(base.y) + Math.Abs(this.z));

}

}
}
