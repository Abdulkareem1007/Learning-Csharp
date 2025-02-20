using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;


//Method Overriding: 
// It is an approach of re-implelenting the parent's class method under the child class with the same name and signature.


// Method Hiding/Shadowing: 
// Method Hiding/Shadowing is also an approach of re-implementing a parent classes method under the child class exactly with the same name and signature. 
// new use new keyword with method on the child class.


// We can re-implement a parent Classes method under child class by using 2 approaches:
// 1. Method Overriding.
// 2. Method Hiding/Shadowing.

// After Re-Implementing parent class's method under the child class.The child class instance will start calling local methods only that is the re-implemented methods.
// But If required in any cenario or in any case we can also call the parent classes method from child class by using 2 approaches:

// 1.Directly Creating instance of parent class in child class. we can call Parent's class method from child class.
// 2. By using base keyword also we can call parent's method from child class.but keywords like this and base can't be used from static block. 



// The difference between two is that:

// In overriding child class re-implements it's parent's method which are declared as virtual.
// Where as in the Method Hiding child class can re-implement any parent class's method even if the method is not declared as virtual.

// In overriding a parent class reference can call child classes overriden member.
// But In Method Hiding a parent class reference cannot call child class method which is re-implelented using Hiding approach.

// In hiding the member are re-implemented are considered as pure child class member.and pure child class member are not accessible to parent's reference.
// In overriding The member that is impelemnted under the child class taking permission from parent class.beacuse it has taken the permission from parent class and overriden member of child class will not considered as pure child class members.

//------------------------------------------------------------//

//Note: 
// if we create a child class instnce and pass it to the parent class instance. it will become parent's reference.
// A parent class reference even if created by using child class instance cannot access any members of the child class which is purely defined under the child class. 
// but it can call overriden member of the child class.

// In overriding parent class has given the child class permission to override the methods. and when child class re-implements those methods the parent class will identify them.
// because the parent class identifies them it was able to call the overriden member of child class(Test1()).

// In Method hiding without taking any permission from the parent class child class stated re-implemeting methdos.Because of it a parent reference will not identify the re-implemented methods. therefore we cannot access the method (Test2()) of class through parent reference.


namespace MethodHiding
{  
    
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
