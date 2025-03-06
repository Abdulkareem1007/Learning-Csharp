using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    internal class TestEmployee
    {

        static void Main(string[] args)
        {
            // creating instance of Employee class.
            Employee emp = new Employee(101, 35000, "John", "Developer", "Development", "Hyderabad");

            // Accessing the value using index.
            /* Console.WriteLine("EmpNo: "+emp[0]);
             Console.WriteLine("EmpName: " + emp[1]);
             Console.WriteLine("Job: " + emp[2]);
             Console.WriteLine("Salary: " + emp[3]);
             Console.WriteLine("Dname: " + emp[4]);
             Console.WriteLine("Location: " + emp[5]);

             Console.WriteLine();
            // updating value using index.
             emp[0] = 5001;

             emp[2] = "Manager";

             emp[3] = 40000.00;

             Console.WriteLine("Updates Empno: " + emp[0]);
             Console.WriteLine("Updates Job: " + emp[2]);
             Console.WriteLine("Updates Salary: " + emp[3]);*/


            // Accessing the value using names.

            Console.WriteLine("EmpNo: " + emp["empno"]);
            Console.WriteLine("EmpName: " + emp["EmpName"]);
            Console.WriteLine("Job: " + emp["Job"]);
            Console.WriteLine("Salary: " + emp["Salary"]);
            Console.WriteLine("Dname: " + emp["dname"]);
            Console.WriteLine("Location: " + emp["location"]);


            Console.WriteLine();
            // Updating value using names.

            emp["EmpName"] = "Smith";
            Console.WriteLine("Updated EmpName: " + emp["empname"]);

            emp["Dname"] = "Finance";
            Console.WriteLine("Updated Dname: " + emp["dname"]);

            emp["Location"] = "Bengaluru";
            Console.WriteLine("Updated Location: " + emp["Location"]);







            Console.ReadLine();
        }
    }
}
