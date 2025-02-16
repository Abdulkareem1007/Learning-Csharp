using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Entity:-  It can anything living or non-living object, anything that is assiciated with a set of attributes is Entity.
//          Example Phone can be Entity it has set of attributes like size,weight ,height,Company etc.. similarly we have customer it can also be Entity.

// To use Inheritance in developing our application we need wo follow following steps:

//  STEP 1: Identifying the Entities that are associated with the application we are developing.
//              
//       Example: If we hare developing the application for school in that case we have Student as entity,TeachingStaff as entity, Non-TeachingStaff as entity.

//  STEP 2: Identify the attributes of each of the entities.

/*      Student             TeachingStaff           Non-TeachingStaff
 *      
 *      -Id                   -Id                       -Id
 *      -Name                 -Name                     -Name
 *      -Address              -Address                  -Address
 *      -Phone                -Phone                    -Phone
 *      -Class                -Designation              -Designation
 *      -Marks                -Salary                   -Salary
 *      -Grade                -Qualification            -DeptName
 *      -Fees                 -Subject                  -MgrId
 */
//
//  STEP 3: Identifying The common attrributes and and put them in hierarchial order..

//
//  STEP 4: Defining the Classes representing the entities that are put in hierarchical order.
//
//      Person Class will have commin attrribute for classes.
/*
   public class Person
    {
      public int Id;
      public string Name, Address, Phome;
    }

//     Student class will have total 7 attributes 4 are inherited from Person class.
   public class Student: Person
    {
       int Class;
       double Marks,fee;
       char Grade;
    }
//   Again TeachingStaff and Non-TeachingStaff also have some common attributes.
so we can make a common class as Staff for TeachingStaff and Non-TeachingStaff and this Staff will also inherit 4 common for attributes for all class that is Person.

   public class Staff:Person
    {
      public string Designation;
      public double Salary;
    }

   public class Teaching:Staff
    {
      string Qualification,Subject;      
    }

   public class Non_Teaching:Staff
    {
      int MgrId
      string Dname;      
    }
 */


namespace InheritanceExample
{
    
    public class Person
    {
        public int Id;
        public string Name, Address, Phone;

        static void Main(string[] args)
        {
        }
    }
}
