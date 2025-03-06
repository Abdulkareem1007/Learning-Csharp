using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Indexers is a member of a class, when we define a indexer in a class the class starts behaving like a virtual array.

// suppose we have a Class representing a Entity Employee and under this we have some attribute:
// -Empno
// -EmpName
// -Job
// -Salary
// -Dname
// -Location

// we can creating a instance in other class. but we can not access the attributes as because they are private member of the class.
// To access we have three options:
        // 1) To make member of class public (Not recommended because then we dont have any control on the value any one can access the value from any where)
        // 2) Defining properties and giving get or set access to giving both get and set access.
        // 3) Defining Indexers it is some thing like property but provide values according to the index positions.

// how to define a Indexer in a class: 

/*[<modifires>] <type> this [<parameter list>]
    {
    [get{ statements}] // Get Accessors.
    [set{ statements}] // Set Accessors.
    }*/

/*Example: 

 public object this [int index]
    {
        get
            {
                statements;
            }

        set
            {  
                statements;
            }
    }



-- [<modifires>] as public: so that it can be access from any where.
-- <type> as object: because we have three different type of value in the attribute int,string,double.
-- this: means that we are defining indexer on the current class(Employee) so that the instance of the current class(emp) will starts providing the access to the value.
-- [<Parameter list>] as [int index]: it can be of any type we have taken as as array.it can be of string type also like [string name]. then we can access attribute as emp[EmpNo],emp[EmpName].
-- get: returning the value.
-- set: assigning in the value.
*/

// we can access the attribute, suppose we have a instance of class Employee as emp created in different class we can access atribute like emp[0],emp[1]... so on.

namespace Indexers
{
    public class Employee
    {
        // Variables representing the attributes of Employee.
        int EmpNo;
        string EmpName, Job, Dname, Location;
        double Salary;

        // Initilizing the arrtibutes with a parametrized constructor.

        public Employee(int EmpNo, double Salary, string EmpName,string Job,string Dname,string Location)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.Job = Job;
            this.Dname = Dname;
            this.Location = Location;
            this.Salary = Salary;
        }

        // defining indexer to provide access to the instance created in out of the class.
        public object this[int index]
        {
            get
            { //index value can start from any number 1,0 or any other.
                if (index == 0) 
                    return EmpNo;
                else if (index == 1)
                    return EmpName;
                else if (index == 2)
                    return Job;
                else if (index == 3)
                    return Salary;
                else if (index == 4)
                    return Dname;
                else if (index == 5)
                    return Location;
                return null;   // appart from value 0-5 null will come.
            }

            set
            {
               if(index == 0)
                {
                    EmpNo = (int)value;  // value is an implicit variable that provide access to the value assigned by the user. 
                    // as Emp no is a int type and value is object type we need to explicitly convert value (object type) to int.
                }

                else if (index == 1)
                {
                    EmpName = (string)value; 
                }
                else if (index == 2)
                {
                    Job = (string)value;
                }

                else if (index == 3)
                {
                    Salary = (double)value;
                }

                else if (index == 4)
                {
                    Dname = (string)value;
                }
               else if (index == 5)
                {
                    Location = (string)value;   
                } 
            }
        }

        // defining indexer to use name insted of index.
        public object this[string name]
        {
            get
            {
                if (name.ToUpper() == "EMPNO")
                {
                    return EmpNo;
                }

                else if (name.ToUpper() == "EMPNAME")
                {
                    return EmpName;
                }
                else if (name.ToUpper() == "JOB")
                {
                    return Job;
                }
                else if (name.ToUpper() == "SALARY")
                {
                    return Salary;

                }
                else if (name.ToUpper() == "DNAME")
                {
                    return Dname;
                }
                else if (name.ToUpper() == "LOCATION")
                {
                    return Location;
                }

                return null;
            }

            set 
                { // if  we convert the name either to upper case or lower case then we will not have wny problem if the useer enter name like emp[Dname] or emp[dname].
                   if(name.ToUpper() == "EMPNO")
                   {
                    EmpNo = (int)value; 
                   }
                   else if(name.ToUpper() == "EMPNAME")
                   {

                     EmpName = (string)value; 
                   }
                   else if (name.ToUpper() == "JOB")
                   {

                    Job = (string)value;
                   }
                   else if (name.ToUpper() == "SALARY")
                   {
                    Salary = (double)value;
                   }
                   else if(name.ToUpper() == "DNAME")
                   {
                     Dname = (string)value;
                   }
                   else if (name.ToUpper() == "LOCATION")
                   {
                    Location = (string)value;   
                   }
            }
        }


        static void Main(string[] args)
        {
        }
    }
}
