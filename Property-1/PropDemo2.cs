using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class PropDemo2
    {
        static void Main(string[] args)
        {
            PropDemo demo = new PropDemo();

            //accessing radius from different class using property.


            double radius = demo.Radius;  // Calling Get accessor of the property.
            
            Console.WriteLine("Getting Radius = "+ radius);

            // setting the radius value.

            demo.Radius = 17.88; // calling the Set accessor of the property.

            Console.WriteLine("Setting New Radius = "+demo.Radius);
        }
    }
}
