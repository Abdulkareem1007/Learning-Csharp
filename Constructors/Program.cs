using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{  
    // Constructor is a spcial method that is present inside the class. And it is a non-value returning Method.
    // The class name and the constructor name is same.
    // It is use for initilizing the variable inside the Class.
    // Every Class requires a consturctor to create an instance of the class.
    // It is a developer's job to create a constructor inside a class.
    // If the developer doesnot create a constructor, at the run time compiler will create a implicit Constructor (Default constructor) for a class with default values.
    // Every varialbes or fields we declear directly under a calss have default value.For for numbric value the default value is Zero ,boolean type as false and for string and object as null.
    // Every time an instance of the class is created the constructor is called.
    // The Constructor Defined if the developer doesnot define a constructor are called implicit Constructor.
    // Implicit constructor are parameter less constructor and they are public.
    internal class Program
    {

        int i;  // variables decleared under a Program Class.
        bool b;
        string str;

        static void Main()
        {
            //Crating instance of the class Program.
            // Here first Program in the class and second Program after new is the Constructor.
            Program p = new Program();  

            Console.WriteLine("integer i: " + p.i +" boolean b: "+p.b + "String str: "+p.str);  //Printing the values of the varuables.
            Console.ReadLine();
        }
        // if we run the above program we will get output as:
        // integer i: 0 boolean b: false string str: 
        // this is the result of the default constructor Created by the complier which initilize the variables with default values.



        //The Types of Constructors:
        // 1) Default or Parameter Less Constructor.
        // 2) Parameterized Constructor.
        // 3) Copy Constructor.
        // 4) Static Constructor.

        // Default or Parameter Less Constructor:  If a constructor method doesnot take any parmeter then it is called as default or parameter less Constructor.
        // these Constructor can be defined by the developer Explicitly. or else will be implicitly defined provided if there is no Explicit Constructor Under the class.


        // Parameterized Constructor: If a Constructor method is defined with parameter then it is a parameterized Constructor.
        // These Constructor can be only be definded by the programmer but never can be defined implicitly.

        // Copy Constructor: when we want to crate multiple instances with the same values then we use Copy Constructor.
          // In a copy constructor the Constructor takes the same Class as a parameter to it.


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
        // these constructors are first to execute unnder any class.

    }
}
