using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Student : Person
    {
        int Class;
        double Marks, Fee;
        char Grade;
        static void Main(string[] args)
        {
            Student student = new Student();

            student.Id = 101;
            student.Name = "John Mills";
            student.Address = "Hyderabad";
            student.Phone = "9988776655";
            student.Class = 12;
            student.Marks = 95;
            student.Grade = 'A';
            student.Fee = 5000;

            Console.WriteLine("---------------Student Details--------------");
            Console.WriteLine(
                  "Student Id: " +student.Id+"\n"
                + "Student Name: " + student.Name + "\n"
                + "Student Address: " + student.Address+ "\n"
                + "Student Phone: " + student.Phone + "\n"
                + "Student Class: " + student.Class + "\n"
                + "Student Marks: " + student.Marks + "\n"
                + "Student Grade: " + student.Grade + "\n" 
                + "Student Fee: " + student.Fee + "\n" );
        }
    }
    
}
