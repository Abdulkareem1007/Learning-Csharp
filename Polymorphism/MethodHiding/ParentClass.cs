using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    internal class ParentClass
    {   
        //This method overridable by child class. 
        public virtual void Test1()
        {
            Console.WriteLine("Method Test1 from parent class");
        }

        public void Test2()
        {
            Console.WriteLine("Method Test2 from parent class");
        }
    }

    class ChildClass : ParentClass
    {
        // this is overriding method.
        public override void Test1()
        {
            Console.WriteLine("Method Test1 from child class");
        }

        // this is Method Hiding / Shadowing.
        public new void Test2() // new keyword is not mandatory.
        {
            Console.WriteLine("Method Test2 from child class");
        }

        //base and this keyword cannot be used in the static block
        public void ParentTest1()
        {
            
            base.Test1 ();
        }

        public void ParentTest2()
        {
            base.Test2();
        }
        static void Main()
        {
            ChildClass c = new ChildClass();    

            c.Test1();
            c.Test2();
            Console.WriteLine();
            //accessing Parent's class method under the child class.

            // directly creating an instance of parent class under child class.

            ParentClass p = new ParentClass();
            Console.WriteLine("Accessing Parent's class method under the child class\n");
            Console.WriteLine("directly creating an instance of parent class under child class.\n");
            p.Test1();
            p.Test2();

            // by using base keyword in child class.
            Console.WriteLine("\nby using base keyword in child class.\n");

            //ParentTest1() and ParentTest2() will act as an interface in calling the parent classes methods from the child class.by using child class instance only.
           
            c.ParentTest1();
            c.ParentTest2();


            // creating a child class instance..

            ChildClass c2 = new ChildClass();

            ParentClass p2 = c2;

            // accessing the child class members.

            //Test1() is re-Implemented by using override.
            //We are able to call Method Test1() of the child which is purely define under child class by uisng child class reference because it is an overriden member of the class.the output will be Test1 from child class.
            Console.WriteLine("\nWe are able to call Method Test1() of the child which is purely define under child class by uisng child class reference because it is an overriden member of the class.");
            p2.Test1();

            // Test2() is re-implemented by using Method Hiding.
            //In this case we cannot call the Method Test2() of the child class because it is non overriden method. and non overriden member can not be accessed by the parent reference. the output will be Test2 from parent class.
            Console.WriteLine("\nIn this case we cannot call the Method Test2() of the child class because it is non overriden method. and non overriden member can not be accessed by the parent reference ");
            p2.Test2();

            Console.ReadLine();
        }
    }

}
