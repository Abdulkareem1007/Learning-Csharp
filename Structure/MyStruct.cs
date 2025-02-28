
// This is a code File.
// This page will be blank when we will first open it.
// We need to Import all the namesapces.

using System;

// the namespace will be same as the project name.

namespace Structures
{

    // inside the namesapce we can define any thing.

    // defining a structure in newly created code file.
    struct MyStruct
    {
        int x;
        public void Display()
        {
            Console.WriteLine("This is a method inside a structure."); 
        }

        public MyStruct(int x)
        {
            this.x = x;
        }

        static void Main()
        {

            // default constructor will initilize the value of x.
            MyStruct s0 = new MyStruct();
            Console.WriteLine("Value of x in s0 is : "+s0.x);


            //new keyword is optional.but if we dont use "new" we need to explicitly initilize the fields after the instance is created.
            MyStruct s1 = new MyStruct();

            //intilizing the fields.
            s1.x = 10;
            
            Console.WriteLine("Value of x in s1 is : " + s1.x);

            //calling Diaplay method
            s1.Display();

            //creating instance with parametrized constructor.
            MyStruct s2 = new MyStruct(20);

            Console.WriteLine("Value of x in s2 is: " + s2.x);

            Console.ReadLine();
        }
    }

}
