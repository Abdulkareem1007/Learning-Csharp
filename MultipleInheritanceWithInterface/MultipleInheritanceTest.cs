using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Multiple Inheritance using Interface: 

// In Object oriented programming there are 5 types of Inheritance:

// 1. Single: One parent class have one child class.
// 2. Multi-level: A class ( GrandParent) class have one child class( parent) and that child class also have a child class(child).
// 3. Hierarchical: a class have multiple child classes.
// 4. Hybrid: It is a combination of multi-level , hierarchical and Multiple means a class have multiple child class and those child class have a common child class.
// 5. Multiple: Multiple parent class have same child class.


// In C# we only have support of Single, Multi-level, hierarchical Inheritance.

// Even If Multiple inheritance is not suppported in C# by the Classes but we can still implement it through Interfaces.

// Note:- The Class can only have One and Only One Immidiate parent. Means that A class cannot have two parent class.
//        But a class can have any number of Interfaces as it's parent. By this we can implement multiple Inheritance Through Inherfaces.



// Question: Why multiple inheritance is not supported through classes but it is supported through interfaces?

// Answer: Why Multiple inheritance is not supported through classes Because suppose if have a class class3 and it is inheriting from two classes Class1 and Class2 and suppose we have two methods in class1 and class2 as test().
//         if class3 inherits from class1 and class2, class3 will have two methods with same name and signature and no class can contain two methods with same name and same signature becase it will cause ambiguity.
//         and in case of class1 and class2 it give two method test()  to class3 to consume the method but in the case of interface it is requesting the child class to implement the methods not to consume that is why will will not hace ambiguity in case of Interfaces.


interface Interface1
{

    // Method definaton
    void Test();
    void Show();
}

interface Interface2
{
    // Method definaton
    void Test();
    void Show();
}

namespace MultipleInheritanceWithInterface
{
    internal class MultipleInheritanceTest: Interface1, Interface2
    {

        // Implementation of method. 
       public void  Test()     // Implementing only one time. it will be for both because Interface1 and Interface2 doesnot know about each other method's name. Interface1 will think method is implementing for it and Inherface2 will think method is implementing for it.
        {
            Console.WriteLine("Interfaces method Implemented in child Class");
        }


        // we can also implement method for both Interfaces as:
        // Note: When we are prefexing method name with interface name we cannot use public modifier. 
       void Interface1.Show()
        {
            Console.WriteLine("Declared in Interface1 and implemented in Class");
        }

        void Interface2.Show()
        {
            Console.WriteLine("Declared in Interface2 and implemented in Class");
        }
            


        static void Main(string[] args)
        {
            MultipleInheritanceTest obj =new MultipleInheritanceTest();
            obj.Test();

            // TO Call the method that is Implemented using Prefixing Interface name to the method's name.


            // We need to create reference of the interface and then call.

            Interface1 i1 = obj;  
            Interface2 i2 = obj;
            
            i1.Show();  
            i2.Show();  


            Console.ReadLine();

            // From above example we can see that a class is having mutiple parent class. so through this we have implemented multiple inheritance. 
        }
    }
}
