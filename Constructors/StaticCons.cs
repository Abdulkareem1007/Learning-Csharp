using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{

    // static Constructor: If a cnstructor is explicitly decleared by using static modifires we call that as static constructors.
    // All the constructors we have defined till now are non static or instance Constructors.
    // when ever we define a static constructor in a class , at the compile time the there will be a constructor implicitly defned by compiler.
    // as 

    /*

     class Test
     {
       static Test()
        {
        }
         public Test()
         {
          }

       }
     */

    // If a class contains any static variables then only the implicit Constructor will be present.or else we need to define then explicitly.
    // where as non static constructors will be defined implicitly defined in every class(Except static class). provided we did not define then explicitly.

    // static constructors are responsible for initilizing static variables and these constructors are never called explicitly.they are called impilictly.
    // these constructors are first to execute under any class.

    // static constructor execute immediately once execution of a class starts.more over it is the first block of code to run under a class.
    // where as non-static constructors executes only after creating instance of a class as well as each and every time the instance of calss is created. 

    //static Constructor are called implicitly.
    // non static are explicitly called.

    // static constructors can't be parameterized so over loading static constructor is not possible.
    // because it is impilicitly called and this will be the first block to execute there for we dont get the chance to pass the value.

    internal class StaticCons
    {
        int x; //non static variable default value 0.initilized by non static constructor.

        static int y; // static variable default value 0. initilized by static constructor.
        //static constructor. 
        static StaticCons()
        {
            Console.WriteLine("static constructor is exeuted.");
        }

        // non static Constructor.
        public StaticCons(int x)
        {
            this.x = x;
            Console.WriteLine("non Static constructor called.");
        }

        static void Main()
        {
            StaticCons cons1 = new StaticCons(5);
            StaticCons cons2 = new StaticCons(10);
            Console.WriteLine("Main Method's WriteLine code is Executed.");
            Console.WriteLine("value of static int y is: "+y);
            Console.WriteLine("value of non-static int x is: " + cons1.x + " and "+ cons2.x);
            Console.ReadLine();
        }

        // Note a staitc member of a class can be directly accessed in a sttic block.
        // the static field will be one and only one copy for the whole class.
        // in above example static member is int y it can be directly accessed.

        // non-static member of a class can never be directly accessed from static block.
        // they can only accessed by using class instance. it is because multiple calss instance will have a copy of instance varible(x).and it will create confussion which x to be called.



        // the output will be:
        // static constructor is exeuted" and then we will get Main Method is Executed.

        // this is happned because static consturctors are first to execute.
        // although (Entery point is main method) the execution will starts from Main method but the before executing code inside the main method.the static constructor code will execute.
        // As we know Constructors areresponsible for inilializing fields/varaibles of a calss.
        // Static fields are initilized by static constructor and non-static fields are initialized by non-static constructor.


        // In the life Cycle of the class static constructor executes one and only one time.
        // where as non static constructor executes for zero time if not instnce is created and "N" time if "N" instance is created.

        // every class constains a implicit constructor if not defined explicitly and those implicit constructor are defined based on the following criteria.

        // Every class  except a static class contains a implicit non static constructor. if not defined with any explicit constructor

        //  a class defined with a static keyword is called static class. It conatins only static member it can not have non static members. therefor it can not have non static constructor.
        // static constructors implicitly defied only if that class constains any static fields. or else static constructor will not be present at all.
    }
}
