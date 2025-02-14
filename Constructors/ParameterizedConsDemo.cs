using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{

    // Parameterized Constructor: If a Constructor method is defined with parameter then it is a parameterized Constructor.
    // These Constructor can be only be definded by the programmer but never can be defined implicitly.
    internal class ParameterizedConsDemo
    {
        int x; //variable under a class.
        // Constructor with parameter.
       public ParameterizedConsDemo( int i)
        {
            x = i;
            Console.WriteLine("Parameterized Constructor is Called: "+i);
        }

        static void Main(string[] args)
        {
            ParameterizedConsDemo para1 = new ParameterizedConsDemo(4);
            ParameterizedConsDemo para2 = new ParameterizedConsDemo(8);

            Console.ReadLine();
        }

        // when we run the above program we will get the output as:
        // Parameterized Constructor is Called: 10
        // Parameterized Constructor is Called: 20
        // this happens because here we have two saperate instance of the class ParameterizedConsDemo para1 and para2
        // when we pass the value 10 when we create instance para1 the the value  20 is assign to x.
        // similarly when we pass the value 20 when we create instance para2 the value 20 is assign to x.
    }
}
