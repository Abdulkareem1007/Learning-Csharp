using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    internal static class StaticClass
    {

        static int x;

       static StaticClass()
        {
            x = 10;
            Console.WriteLine("Static Constructor is Called Value of x: "+x);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

        }
    }
}
