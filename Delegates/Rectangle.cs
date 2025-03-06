using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // defining a delegate.

    public delegate void RectDelg(double width, double height);

    internal class Rectangle
    {
        public void GetArea(double width, double height)
        {
            Console.WriteLine("Area: "+width * height);
        }

        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine("Perimeter: "+(2*(width + height)));
        }

        static void Main()
        {
            Rectangle r = new Rectangle();

            /*r.GetArea(8, 4);
            r.GetPerimeter(8, 4);*/

            // Creating instance of the delegate.

            RectDelg rectdlg = new RectDelg(r.GetArea);

            // to call other method with same delegate.
            rectdlg += r.GetPerimeter;

            // one single delegate call will execute both the two methods
            rectdlg.Invoke(8, 2);

            // calling delegate with different width and height to find the area and perimeter of rectangle
            rectdlg.Invoke(5, 2);

            Console.ReadLine();
        }
    }
}
