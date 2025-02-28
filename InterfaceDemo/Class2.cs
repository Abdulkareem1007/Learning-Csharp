using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Class2:Class1
    {   
        // we are passing value to the class1's constructor
        //as class 2 constructor will call the class1's constructor.
        // we are using :base()  to pass the value "a" to the class1's constructor.
        // while we create instance of class2 we are passing the value. First it reached to int a the it passed to base(a) then finally the value will teach to the perimeter of the class1's constructor.
        public Class2(int a):base(a)
        {
            Console.WriteLine("This is class2 Constructor");
        } 
        public void test3()
        {
            Console.WriteLine("This is method three of the Class2");
        }
        static void Main(string[] args)
        {
            Class2 c = new Class2(5);

            c.test1();
            c.test2();
            c.test4();
            c.test3();

            //point 2
            Class1 c1 = new Class1 (5);
            c1.test1();
            c1.test2();
            c1.test4();
            // we cannot access the member of Class2(child class) from class1(parent class)
            /*c1.test3();*/


            // point 3
            Class1 p; // p is a calss variable.
            
            Class2 g= new Class2 (5);  // instance of class2


            // here we initialize the parent class variable using child class instance.
            p= g; // we are initializing parent class variable p by using instance c.now p is the reference of the class2 instance c. Here instance p and c are saring memory.

            p.test1 ();
            p.test2();
            p.test4();



        }
    }
}
