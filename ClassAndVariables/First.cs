using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndVariables
{
    // Class is a blueprint of instance
    // it is a user define datatype.
    // when we create a class we are creating a user define type(datatype).
    // example of such type is string. string is also a class.
    // we never consume a class directly we create an instance(copy) of it and then we consume it.
    
   /* Example: we never consume int like : int = 10;
               we write int a = 100;  here a is a copy of int type.

    similarly: we can not use string ="hello"; we use string s = "hello"; here s is a copy of type string.
   */
            
     // Note:-  Variable of a class is a copy of a class that is not initlized.

    //  Example: First cyp;  if we initilize cpy with new key word it will become instance of the class.
    internal class First
    {
        int x = 100;
        static void Main(string[] args )
        { // to print the value of x we need to first create an instance of the class First.
            

            First obj1 = new First(); // b is the intance of Class First.

             obj1.x = 200; // modifying the value of x of instance obj1 doesnot effect other instance value.

            Console.WriteLine( "Value of obj1:"+ obj1.x );


            // creating the instance of the Class First.
            First obj2 = new First(); // a is the instance of Class Fist

            // Accessing the value of the X present in class 
            Console.WriteLine("value of obj2:" + obj2.x);

            Console.ReadLine();


        }
    }
}
