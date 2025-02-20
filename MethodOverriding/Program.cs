using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Method Overriding.

// It is an approach of re-implementing a parent class's method under the child class with same signature.
// Example:- assume that there is a class1 with a method Test(), and a class2 that is inheriting from class1 then class2 will automatically have Test(). Now in class2 if we again define a method with same name Test() this is Method Overriding.

// Difference between overloading and Overriding.

// Overloading:
// 1) In this case we define multiple methods with the same name by changing their parameters.
// 2) This can be perform either with in the class or between parent child classes. 
// 3) While overloading the parent class's method under the child class, child class doesnot require to take any permission from parent class.             
// 4) OverLoading is all about defining multiple behaviours to a method.


// Overriding:
// 1) In this case we define multiple methods with the same name and same parameters.
// 2) This can be performed only between parent child classes. it can never be performed within the same classes.
// 3) While overriding the parent class's method under the child class,   child class requires a permission from it's parent class. 
// 4) The parents Class's method should defined with 'virtual' keyword and the child class's method that is overriding the parent's method is defined with "override" keyword.
// 5) Overriding is all about changing the behaviour of the parent's class method under the child class.

namespace MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
