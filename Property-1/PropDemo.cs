using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Properties are the members of a class using which we can expose values associated with a Class to the outside environment.

// Suppose we have a class Called Circle (it is an entity) which have a attribute radius. ant it is a public class.

// and we have another class called TestClass and as the Circle class is public we can create instance of it inside TestClass.
// although we have created the instance and memory is also allocated we cannot access the attribute radius as it is a private member of a class.
// we can explicitly make radius to public to access it through instance.

// now we can access the radius and we can also update it.

//Example:

//  public Circle
//   {
//      public double radius = 11.65;
//   }
//
//  public TestClass
//   {
//      static void Main()
//      {
//          Circle c = new Circle();
//          double radius  = c.radius;         // Getting the value.
//          c.radius = 15.67;                  // setting a new value
//      }
//   }
//
// Here the problem is that once the variable of a class is decleard as public any one can get the value and any one can set the value.
// we dont have control on the value.

// To solve this problem we should never declare the Fields of a class as public.
// Always declare fields as private.

// one way to get the value and set the value is using the methods.

// Example: 
/*
   public Circle
   {
     private double radius = 11.65;

      public double GetRadius()    //provide get access to the value.
       {
         return radius;
       }

        public void SetRadius(double Value)  // provide set access to the radius.
           {
               radius = value;
            }
   }

  public TestClass
  {
    static void Main()
      {
        Circle c = new Circle(); 
        c.GetRadius();  
        c.SetRadius(18.45);
     }
  }*/


// From above example we If we want we can just provide get access , set access or get and set access to the user.

// Another way to provide get and set access to the user is by using Properties.

// Syntax of properties:-

/* [<modifiers>] <type> <Name>
 *  { 
 *   [get{<statements>}]   // Get Accessor
 *  
 *   [set{<statements>}]   // set Accessor 
 *  }
 */

/*  Example: 
 *  
 *  public double RadiusProp
 *  {   
 *      get { return radius;} //Represents a value returning method without any parameter.
 *      
 *      set{ radius = value; } // Represents a non-value returning method with parameter.
 *      
    }
 */
// In above example in get we are simply returning the radius value.

// In set we are setting the value of the radius. we dont need to declare the value.it is implicitly declare.
// the datatype of value will same as the type of property.

// If we Only write Get accessor it will only give get access means that the property will be ReadOnly.
// we can also write only set accessor to the property. this will make the property WriteOnly.
// If we write both then it will become read write.

// Get accessor is a value returning method without any parameter.
// Set accessor is a non value returning method with parameter.

// the get and set are same as get and set methods we define in above example.


// Note:- General convention if we want to define a property to the fields(Variable). We should Name that variable Prefexing with Underscore ( _ )
//        Example: variable name = _Radius

// we can also write some condition in the code like if we want that in set accessor if the Radius value is greater than the preent value then only it will set the value other wise it will not set the value.

// conditon: if (value >_Radius)
//              {
//                  _Radius = value;
//              }

// here the value is user defined radius. if Condition satisfys new value will be updates or else old value will be printed.


namespace Properties
{
    internal class PropDemo
    {
        double _Radius = 15.67;

        public double Radius

        { get {  return _Radius; } 

          set { 
                if(value > _Radius)
                _Radius = value;
            } 
        }
    }
}
