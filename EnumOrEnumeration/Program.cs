using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Enumeration or Enum Types:

// It is a set of named Constant values. IT is also a user defined type. so it is always better to define enum directly under the namespace.
// It is also possible to define a enum under a class or Structure.


// Syntax: [<modifiers>] enum <Name of enum> [: <type>] { --list of named constant value }

namespace EnumerationOrEnumTypes
{
    // by default the index will starts form 0 we can force it to start from what ever number we want.
    // by initilizing the first value with the index of our choice. not only first value we and give the index value to each value in the enum.
    // by default enum contains int values we can change it to: byte, short, int, long, uint, ushort, ulong and sbyte also. 
    public enum Days :byte
    {
        Monday=1,
        Tuesda=2,
        Wednesday=9,
        Thursday=10,
        Friday=15
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            // example of a enum.
            // if we want to change the background color of the displayed text on console we can use enum.

            // here the ConsoleColor is a enum that contains list of color.
         /*   Console.BackgroundColor = ConsoleColor.Blue;   
            Console.WriteLine("Example to change the color of the text");
*/
            // If we want to provide a set of days and the user can only select it from that selected we can use enum to do that.

            // use d as a variable and internaly values stored in enum have index starting from 0.

            // we need to convert index value to days by using (Days)0, (Days)1 etc.

            Days d1 = (Days)1;

            Days d2 = (Days)2;

            
            Console.WriteLine("Day1 = "+d1);
            Console.WriteLine("Day2 = " + d2);

            // In This Case we Dont have 5th value that is why it will print 5 as value.

            Days d3 = (Days)7;
            Console.WriteLine("Day3 = " + d3);

            // we can also choose list of availabel value by writing Days.(value from list).

            Days d4 = Days.Thursday;

            Console.WriteLine("Day4 = "+d4);

            // we can also get integer representation of the Days as  (int)d.

            Console.WriteLine("Day number of " + d4 + " = " + (int)d4);
            

            // we can display all the value of emun using foreach loop.


            // to display the all the integer(index) of the enum.

            // .GetValue take Type as a parameter. when ever method takes type as a parameter we need to use typeof then pass the value to find its type.

            Console.WriteLine("\nDisplay integer values:\n");

            foreach(byte i in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(i);
            }

            // to display all the values in enum.
            Console.WriteLine("\nAll the value present in enum\n");

            foreach (string s in Enum.GetNames(typeof(Days))) 
            {
                Console.WriteLine(s);
            }

            //to get name and value side by side.

            Console.WriteLine("\nDays and value side by side\n");

            foreach(byte i in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine((Days)i + " : " + i);
            }
        }

    }
}
