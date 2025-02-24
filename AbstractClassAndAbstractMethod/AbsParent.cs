using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndAbstractMethod
{
    abstract class AbsParent
    {
        public void Add(int x,int y)
        {
            Console.WriteLine("Sum: "+ (x+y));
        }

        public void Sub(int x, int y)
        {
            Console.WriteLine("Sub: " + (x - y));
        }

        public abstract void Multi(int x, int y);
        public abstract void Div(int x, int y);

       
    }
}
