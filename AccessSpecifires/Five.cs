using AccessSpecifires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifires2
{
    class Five
    {

        static void Main(string[] args)
        {
            // Creating instance of the Program class in AccessSpecifire.

             AccessSpecifires.Program p = new AccessSpecifires.Program();

            // Case 5: consuming member of the Class program from the non-child class of different project.

            // private member can not accessed from the non-child class of the different project 

            /* p.Test1();*/

            // internal member can not accessed from the non-child class of the different project 
            /*p.Test2();*/

            // protected member can not accessed from the non-child class of the different project 
            /*p.Test3();*/

            // Protected internal member can not accessed from the non-child class of the different project 
            /*p.Test4();*/

            // private protected member can not accessed from the non-child class of the different project 
            /*p.test5();*/

            // public member can be accessed from the non-child class of the different project 

            p.Test6();

        }
       

        
    }
}
