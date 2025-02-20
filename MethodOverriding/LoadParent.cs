using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class LoadParent
    {
        public void Show()
        {
            Console.WriteLine("Parent's Show Method Is Called");
        }
        public virtual void Test() // Overridable method.
        {
            Console.WriteLine("Parent's Test Method Is Called");
        }

    }

    class LoadChild : LoadParent 
    {
        // overloadig show method.
        public void Show(int i)
        {
            Console.WriteLine("Child Class show method is called");
        }

        //overiding Test Method.

        public override void Test()
        {
            Console.WriteLine("Child's Test Method Is Called");
        }
        static void Main()
        {
            LoadChild c = new LoadChild();


            c.Show(1);
            c.Show();

            c.Test();
            
        }
    }

}
