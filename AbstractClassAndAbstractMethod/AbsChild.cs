using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndAbstractMethod
{
    internal class AbsChild:AbsParent
    {
        public override void Multi(int x, int y)
        {
            Console.WriteLine("Multiplication: " + (x * y));
        }

        public override void Div(int x, int y)
        {
            Console.WriteLine("Division: " + (x / y));
        }

        static void Main(string[] args)
        {
         
            AbsChild c = new AbsChild();

            c.Add(5, 10);
            c.Sub(8, 2);
            c.Multi(5, 10);
            c.Div(5, 2);

           

            // Invalid statement because we cannot create instance of abstract class.
            /*  AbsParent p = new AbsParent();*/

            // we can create reference of parent class.

            AbsParent p = c;

            p.Add(5, 10);
            p.Sub(8, 2);
            p.Multi(5, 10);
            p.Div(5, 2);

            Console.ReadLine();

        }
    }
}
