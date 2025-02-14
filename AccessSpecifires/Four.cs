using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccessSpecifires2
{
    //we want to inherit the Class Program from the project AccessSpecifires we need to add the reference first to do so:
    // Right Click on the project AccessSpecifire2 and then add then select Add Reference... it will open a window called reference manager new go to browser then select the assembly  it location.
    // it will present inside (project folder) => bin => debug => select the .exe file.
    // after adding the reference we again have two ways of inheriting the member inheretance and by creating instance.
    
    // by using inhertance
    class Four:AccessSpecifires.Program
    {

        static void Main(string[] args)
        {
            // Case 4: Consuming members of the class Program from child class of different project.

            Four four = new Four();

            //private member cannot accessed from the child class of different project. 
            /*four.Test1();*/

            //internal member cannot accessed from the child class of the different project 
            /*four.Test2();*/

            //protected member can be accessed from the child class of the different project 
            four.Test3();

            //protected internal member can be accessed from the child class of the different project 
            four.Test4();
            //private protected member can not accessed from the child class of the different project 
            /*four.Test5();*/

            //public member can  accessed from the child class of the different project 
            four.Test6();

            Console.ReadLine(); 

        }
    }
}
