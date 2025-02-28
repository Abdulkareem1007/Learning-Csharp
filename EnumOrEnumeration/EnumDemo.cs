using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Problem statement: If want to make a program that lets user to delect the meeting date bt it should only the working days (Monday - Friday).
//                    I also want that user cannot Enter the day that is not available i.e (Saturday - Sunday).
//                    Also the default meeting date is Monday.
namespace EnumerationOrEnumTypes
{

    public enum Day {Monday = 1,Tuesday=2,Wednesday=3,Thrusday = 4,Firday = 5 }

    internal class EnumDemo
    {

        //defining a prpoerty to get and set the value.
        // the property is Day type.
        // setting default value to monday
        public static Day meetingdate { get; set; } =Day.Monday;


        static void Main(string[] args)
        {
            //default meething date.
            /*Console.WriteLine("Meeting date is: "+meetingdate);*/

            // if user want to select the meeting date.but it will only allow pirticular list.

            meetingdate = Day.Wednesday;

            Console.WriteLine("User selected Date: "+meetingdate);

            Console.ReadLine();
        }

    }
}
