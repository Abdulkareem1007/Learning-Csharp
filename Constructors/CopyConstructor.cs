using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    
    // Copy Constructor: when we want to crate multiple instances with the same values then we use Copy Constructor.
     // In a copy constructor the Constructor takes the same Class as a parameter to it.
     // if we want to create multiple instance with same value we need to pass the value in the parameter of the constructor method again and again.
     // And if we have 10-20 parameter values it will time taking,thats is why we use copy constructor.
     // the copy constructor will take same class as the parameter. ex: public CopyConstructor(CopyConstructor obj).

     //how it will work: because any class user create is a user defined type, it is a new datatype.
    internal class CopyConstructor
    {
        /* int x;

         public CopyConstructor(int i)
         {
             x = i; 
         }

         // this is a copy constructor.
         public CopyConstructor(CopyConstructor obj)
         {
             // here first x the local copy of copy constructor.
             // and 2nd x is the x present in the actual constructor.
             x = obj.x; 

         }

         public void Display()
         {
             Console.WriteLine("The Value of x is: " + x);

         }

         static void Main(string[] args)
         {
             CopyConstructor CopyCons1 = new CopyConstructor(10);
             CopyCons1.Display();

             // here we are passing the instance CopyCons1
             CopyConstructor CopyCons2 = new CopyConstructor(CopyCons1);
             CopyCons2.Display();

             Console.ReadLine();


             // The output of both instance will be same because we are passing instance CopyCons1 to the copy constructor as parameter in CopyCons2.
         }*/


        //Example of using copy Consturctor to createing multiple instance with same values.
        int id;
        string name;
        double fee;

        public CopyConstructor(int id, string name, double fee)
        {
            this.id = id;
            this.name = name;
            this.fee = fee;
        }

        public CopyConstructor(CopyConstructor obj)
        {
            this.id = obj.id;
            this.name = obj.name;
            this.fee = obj.fee;
        }

        public void Display()
        {
            Console.WriteLine("Id is: " + id);
            Console.WriteLine("Name is: " + name);
            Console.WriteLine("Fee is: " + fee);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            CopyConstructor cpyCons1 = new CopyConstructor(101, "John", 2000);
            cpyCons1.Display();

            CopyConstructor cpyCons2 = new CopyConstructor(cpyCons1);
            cpyCons2.Display();

            Console.ReadLine();
        }
    }
}
