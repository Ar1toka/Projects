using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task23
{
    class Program
    {
//         private Rectangle intersectExample2()
//{
//    // Initialize new rectangle.
//    Rectangle myRectangle = new Rectangle();

//    // The Location property specifies the coordinates of the upper left-hand 
//    // corner of the rectangle. 
//    myRectangle.Location = new Point(10, 5);

//    // Set the Size property of the rectangle with a width of 200
//    // and a height of 50.
//    myRectangle.Size = new Size(200, 50);

//    // Create second rectangle to compare to the first.
//    Rectangle myRectangle2 = new Rectangle();
//    myRectangle2.Location = new Point(0, 0);
//    myRectangle2.Size = new Size(200, 50);

//    // Intersect method finds the intersection between the specified rectangles and 
//    // returns the result as a Rect. If there is no intersection then the Empty Rect 
//    // is returned. resultRectangle has a size of 190,45 and location of 10,5. 
//    Rectangle resultRectangle = Rectangle.Intersect(myRectangle, myRectangle2);

//    return resultRectangle;

//}

        static void Main(string[] args)
        {
            Console.Write("Введите значение Х1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение Y1: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение H1: ");
            int h1 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение W1: ");
            int w1 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение Х2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение Y2: ");
            int y2 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение H2: ");
            int h2 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение W2: ");
            int w2 = int.Parse(Console.ReadLine());

            Rectangle rectangle1 = new Rectangle(x1, y1, x1+w1, y1+h1);
            Rectangle rectangle2 = new Rectangle(x2, y2, x2+w2, y2+h2);

            Rectangle resultRectangle = Rectangle.Intersect(rectangle1, rectangle2);
            Console.WriteLine(resultRectangle);
            Console.ReadLine();
        }
    }
}
