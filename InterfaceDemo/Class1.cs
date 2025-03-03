using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{

    // Inheritance is the mechanism of consuming the members that are defined in the other class.
    // It is done my establishing the parent-child relationship between the classes. parent = (parent,base,super)class , child = (child,derived,sub)class.
    // suppose we have two classes class1 and class2 through inheritance we can consume all the members of class1 from class2.
    // it provide reusability.

    //Note: the Child Class can consume the members of the Parent Class as if the Child class is the owner of the members.
    //      except the private member of the parent class.

    // Important things to know about the inheritance:

    // 1) Parent classes constructor must be accessible to child class.other wise inheritance will not be possible. 
    //    class 1 have Explicit/implicit conturctor and when we execute class2 then class1 constructor will be called.
    //    when ever child class instance is crated the child class constructor will call its parent class's constructor.
    //    That is why the parent class's constructor must be public. it is not neccessary to have child class constructor to be public if this child class dosnot have any child class of it own.
    //    why parent class's constructor is called when we create instance of child class because the members of class1 are only initilized after the constructor of class1 is called so that class2 can consume it.

    // 2) In inheritance child class can access the parent class's members but parent class can never access the members  that is purely defined under the child class.
    //
    //   
    // 3) We can initialize the parent class's variable by using the child class instance.
    //    To make it as reference(reference is a pointer to an instance which doesnot have any memory allocation.)
    //    so that the reference will be consuming the memory of child class instance.
    //    now also we cannot call any purely child class member by using the the reference.
    //
    //
    // 4) Every class taht is defined by us or any predefined class in the libraries of language has a default parent class i.e object class of the system namespace.
    //    every class we create or predefined class inherit 4 important member of the object class (Equals,GetHashCode, GetType, ToString). 
    //    We can call these member from any where.
    //    At the time of compilation this inheritance will take place.
    //

    //  Types of Inheritance:
    //                       A number of parent class a child class have or a number if child class a parent class have.
    // According to C++ there are Five types of inheritance we have:

    //          -- Single: Suppose Class2 inherit from class1 and class2 have one parent to it.
    //          -- Multi-Level: suppose we have class1 class2 class3 where class3 inherit from class2 and class2 inherit from class1.
    //          -- Hierarchical: when one parent class have multiple children suppose class1 have children class2a and class2b.
    //          -- Hydrid: combination of multi-level and hierarchical is known as hybrif suppose class1 have multiple children class2a and class2b and then class2a and class2b have children class3.
    //          -- Mutiple: when one child class have multiple parent classes.suppose child class1 have parent classes class2 and class3.

    // summary:
    //          we can say there is basically two inheritance these are Single inheritance and Multiple inheritance.
    //          If at all a class has 1 immediate parent class to it we call it as single interitance.
    //          If a class has more than i immediate parent class to it we call it as Multiple inheritance

    // 5) In C# we dont have support for multiple inheritance with class, what we have proided is single inheritance with class.


    // 6) In the first point we learnt wehen ever child classs instance is created child class constructor wil implicitly call its parent classes constructor.
    //    But only if the constructor is parameter less if the constructor of parent class is parametrizrd child class constructor cannnot implictly class its parent class constructor.
    //    so to over come the problem it is responsibility of the programmer to explicitly call parent class's constructor from child classe's constructor and pass the value to those parameters.
    //    To call the  parent's constructor from child class we need to se base keyword.
    internal class Class1
    {
        public Class1(int i)
        {
            Console.WriteLine("This is class1 Constructor");
        }
        public void test1()
        {
            Console.WriteLine("This is method one of the Class1");
        }

        public void test2()
        {
            Console.WriteLine("This is method two of the Class1");
        }

        public void test4()
        {
            Console.WriteLine("This is method three of the class2");
        }
        static void Main(string[] args)
        {

            //Point 4.

            Object obj = new Object(); // Object is a root class our system namespace.

            // OBJ WILL HAVE 4 METHODS (Equals,GetHashCode, GetType, ToString). 
            // as object is parent class for all the class there 4 class1 will also have these 4 methods.

            Class1 c = new Class1(5);
            c.Equals(obj);
            c.GetHashCode();
            c.ToString();
            c.GetType();

            // for class2 the object class will become grand-parent. as the parent of the class1 is object and parent of class2 is class1.
            
        }
    }
}
