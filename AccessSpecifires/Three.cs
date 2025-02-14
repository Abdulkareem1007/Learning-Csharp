using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifires
{
    class Three
    {
        static void Main(string[] args)
        {
            //Another way to call the members of the class Program without inheratence.
            // We can call by creating instance of the class.

           // Case 3: //Conuming members of a class from non-child class of the same project.

            Program p = new Program();

            //  // we can not call the private member of the class by creating instance of the class program.
           /* p.Test1();*/

            // we can call the internal member of the class by creating instance of the class program.
            p.Test2();

            // we cannot  call the protected member of the class by creating instance of the class program.it can only accessible by child class
            /* p.Test3();*/

            // we can call the  Protected internal member of the class by creating instance of the class program.
            p.Test4();

            // we can not call the private protected member of the class by creating instance of the class program.
            /*p.Test5();*/

            // we can call public member of the class by creating instance of the class program.
            p.Test6();
        }
    }
}
