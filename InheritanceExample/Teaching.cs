using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Teaching : Staff
    {
        string Qualification, Subject;
        static void Main(string[] args)
        {
            Teaching teachingStaff = new Teaching();

            teachingStaff.Id = 201;
            teachingStaff.Name = "Raj Kumar";
            teachingStaff.Address = "Hyderabad";
            teachingStaff.Phone = "9988776655";
            teachingStaff.Qualification = "B.Ed";
            teachingStaff.Subject = "Csharp";
            teachingStaff.Designation = "Teacher";
            teachingStaff.Salary = 35000;

            Console.WriteLine("---------------TeachingStaff Details--------------");
            Console.WriteLine(
                  "TeachingStaff Id: " + teachingStaff.Id + "\n"
                + "TeachingStaff Name: " + teachingStaff.Name + "\n"
                + "TeachingStaff Address: " + teachingStaff.Address + "\n"
                + "TeachingStaff Phone: " + teachingStaff.Phone + "\n"
                + "TeachingStaff Qualification: " + teachingStaff.Qualification + "\n"
                + "TeachingStaff Subject: " + teachingStaff.Subject + "\n"
                + "TeachingStaff Designation: " + teachingStaff.Designation + "\n"
                + "TeachingStaff Salary: " + teachingStaff.Salary + "\n");

        }
    }
}
