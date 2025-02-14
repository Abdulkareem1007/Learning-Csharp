using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndVariables
{
    internal class RefferenceOfAClass
    {

        int num1 = 10;

        static void Main(string[] args)
        {
            // A refference of a class is like a instance is a pointer to another instance.
            // the instance of the class doesnot have a saperate memory. it has the same memory as the instance it is pointing to.

            RefferenceOfAClass f1 = new RefferenceOfAClass(); // a instance of a class.

            RefferenceOfAClass f2 = f1; // here f2 is the instance of the class f1.

            Console.WriteLine("Value of num1 before changing by reference of calss: "+f1.num1);

            f2.num1 = 20; // changing the value by reffeence od the class.

            Console.WriteLine("Value of num1 before changing by reference of calss: " + f1.num1);

        }
    }
}
