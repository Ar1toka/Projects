using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите значение Х1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Введите значение H1: ");
            double h1 = double.Parse(Console.ReadLine());
            Console.Write("Введите значение W1: ");
            double w1 = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Х2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Y2: ");
            double y2 = double.Parse(Console.ReadLine());
            Console.Write("Введите значение H2: ");
            double h2 = double.Parse(Console.ReadLine());
            Console.Write("Введите значение W2: ");
            double w2 = double.Parse(Console.ReadLine());

            private Rect intersectExample2()
{
    // Initialize new rectangle.
    Rect myRectangle = new Rect();

    // The Location property specifies the coordinates of the upper left-hand 
    // corner of the rectangle. 
    myRectangle.Location = new Point(10, 5);

    // Set the Size property of the rectangle with a width of 200
    // and a height of 50.
    myRectangle.Size = new Size(200, 50);

    // Create second rectangle to compare to the first.
    Rect myRectangle2 = new Rect();
    myRectangle2.Location = new Point(0, 0);
    myRectangle2.Size = new Size(200, 50);

    // Intersect method finds the intersection between the specified rectangles and 
    // returns the result as a Rect. If there is no intersection then the Empty Rect 
    // is returned. resultRectangle has a size of 190,45 and location of 10,5. 
    Rect resultRectangle = Rect.Intersect(myRectangle, myRectangle2);

    return resultRectangle;

}


        }
    }
}
