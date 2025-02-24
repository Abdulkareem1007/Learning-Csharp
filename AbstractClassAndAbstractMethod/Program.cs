using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Abstract Class and Abstract Methods.

// Abstract Methods: The method without any method body is knows as abstract method. What is has is only method declaraction.

// Example: Public abstract void add(int x,int y);

// Note: A abstract method is defined with "abstract" keyword.

// If a method is decleared as abstract as under any class then the child class of that class is responsible for implementing the the method.child class have to implement those obstract methods without fail.

// The concept of abstract methods will be near similar to the concept of Method Overriding.

// In Method overriding suppose if we have class1 as parent which have Virtual method we can implement those in out class2 Child class it is optional with override keyword.

//Method Overriding
/* public Class1
   {
    public virutal void show()
     {
     }
    }
  
  public Class2:Class1
  {
        // this is optional
       public override void show()
        {
            -- re-implemented method      
        }

 */


// In Abstract mehtod if we have Class1 parent class as abstract class which have abstract method. the child class Class2 have to implement the abstract method with override keyword without fail it is mandatory.

// Abstract Method
/* public Class1
   {
    public abstract void show();
     
    }
  
  public Class2:Class1
  {
        // this is Mandatory.
       public override void show()
        {
            -- implementation      
        }

 */


// Abstract Class: If a Class contains Abstract members in it (abstract methods) it must have to be defined with abstract keyword then these classes are called abstract class..

// A Non-abstract class can only contain non-abstract members but Abstract Class can contains both abastract member and non-abstract members.

// If a parent abstract class have both abstract and non-abstract members then the child restractions means it has to implement the abstract members to reimplement the non anstract members.

// Note: we cannot crate an instance of a abstract class which have abstract member in it. the child class must inherit and implement the Abstract member of class to use access all the member of parent class.
         // we can create the reference of the parent class from child class instance as: AbsParent p = c;  here c is the instance of child class.
/* Example: public abstract Class1
 *          {
 *              public abstract void add(int x,int y);
 *          }

*/
namespace AbstractClassAndAbstractMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
