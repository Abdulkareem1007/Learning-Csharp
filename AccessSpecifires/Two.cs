using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifires
{

    // inheriting from class Program.

    // Accordin to Rules of inheritance Parent Class member will become child class member and child class can access members of parent class.

    class Two:Program
    {
        static void Main(string[] args)
        {   

           // Case 2:  //Consuming member of the class from the child class of same project.
            Two two = new Two();

            // as the Method Test1 is private in the class program thats is why we can not access it in the child class.
            // Private members can only be accessed with in the class in which it was defined.

            /*two.Test1();*/

            // internal can  be accessed from the child class.
            two.Test2();

            // protected can be accessed from the child class.
            two.Test3();  
            
            // protected internal can be accessed from the child class.
            two.Test4(); 
            
            // private Protected can be accessed from the child class.
            two.Test5();

            //public can be accessed from the child class.
            two.Test6();
        }


    }
}
