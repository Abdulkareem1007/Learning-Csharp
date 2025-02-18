using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Method OverLOading it is a approach of defining multiple methods under the class with a same name.
// We can implement Method overloading by either mathod with same name but different number od parameter, different order of parameter,different type of parameter.


// Note: a change in the return type of the method will be counted my overloading only chnage in parameter will be counted.
namespace MethodOverLoading
{
    internal class Program
    {       
        //methods with different number of parameter.
        public void test()
        {
            Console.WriteLine("This is a method with no paramtert");
        }

        // this is invalid overloading and will give error.
     /*   public string test()
        {

        }*/

        public void test(int i)
        {
            Console.WriteLine("This is a method with different number of parameter");
        }

        //method with different type of parameter.
        public void test(string s)
        {
            Console.WriteLine("This is a method with different type of parameter");

        }

        //method with different order of parameter.
        public void test(int i,string s)
        {
            Console.WriteLine("this is a method with different type as well as different number of parameter");
        }

        public void test(string s,int i)
        {
            Console.WriteLine("This is a method with different order of parameter");
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            p.test();
            p.test(1);
            p.test("hii");
            p.test("hii", 1);
            p.test(1, "hii");

            // Why OverLoading of the Methods:
            // Method Overloading is the approach of defining behaviours to method.Here the method is same but behaviours are different. 
            // Overloading comes unser the oops concept that i.e Polymorphism.

            //Polymorphism : it is changing of the behaviour based on inputs.

            //Example of method overloading using string.

            string s = "Hello World";

            Console.WriteLine("First occurance of 'o' is at index: "+ s.IndexOf('o')); // takes char as parameter


            // takes char and int as parameter.
            Console.WriteLine("Second occurance of 'o' is at index: " + s.IndexOf('o', 5)); // search will starts from 5th index.

            // take string as parameter.
            Console.WriteLine("Index where 'll' is present: " + s.IndexOf("ll"));
        }
    }
}
