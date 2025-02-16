using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Non_Teaching : Staff
    {
        int MgrId;
       string Dname;
        static void Main(string[] args)
        {

            Non_Teaching non_TeachingStaff = new Non_Teaching();

            non_TeachingStaff.Id = 301;
            non_TeachingStaff.Name = "Ahmed";
            non_TeachingStaff.Address = "Hyderabad";
            non_TeachingStaff.Phone = "9988776655";
            non_TeachingStaff.MgrId = 301;
            non_TeachingStaff.Dname = "Finance";
            non_TeachingStaff.Designation = "Clark";
            non_TeachingStaff.Salary = 35000;

            Console.WriteLine("---------------Non_TeachingStaff Details--------------");
            Console.WriteLine(
                  "Non_TeachingStaff Id: " + non_TeachingStaff.Id + "\n"
                + "Non_TeachingStaff Name: " + non_TeachingStaff.Name + "\n"
                + "Non_TeachingStaff Address: " + non_TeachingStaff.Address + "\n"
                + "Non_TeachingStaff Phone: " + non_TeachingStaff.Phone + "\n"
                + "Non_TeachingStaff MgrId: " + non_TeachingStaff.MgrId + "\n"
                + "Non_TeachingStaff Dname: " + non_TeachingStaff.Dname + "\n"
                + "Non_TeachingStaff Designation: " + non_TeachingStaff.Designation + "\n"
                + "Non_TeachingStaff Salary: " + non_TeachingStaff.Salary + "\n");
        }
    }
}
