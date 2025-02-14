using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{

    // When developer create a constructor it is a Explicit Constructor.
    // Explicit Constructor Can be of both parameter and parameter-less.
    //  When we create a constructor Explicitly we can initilize the value of the variabe accouding to out need.
    // Every time we create the constructor we are calling the Constructor.
    internal class ExplicitConsDemo
    {
        int i;
        bool b;
        string s;

        ExplicitConsDemo()
        {
            i = 5;
            b=true;
            s = "Hello from Constructor.";
        }
        

        static void Main(string[] args)
        {
            ExplicitConsDemo demo = new ExplicitConsDemo();

            Console.WriteLine("Integer i: "+demo.i+" Boolean b: "+ demo.b+ " String s: "+ demo.s);

            Console.ReadLine();
        }
        // the output of the above program is as below.
        //Integer i: 5 Boolean b: TrueString s: Hello from Constructor.
    }
}
