using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo2
{
    internal class TestCustomer
    {

        static void Main(string[] args)
        {
            Customer cust = new Customer(1001,true,"John Smith",6000.00,Cities.Hyderabad,"Telangana","India");

            // here the cust in class TestCustomer can not access the Fields( variables ) values because the fields are declared as private in the class. although it have created the instance.

            // to access the value we need to take help of property.

            Console.WriteLine("Cutomer ID: "+cust.CustId);   

            if(cust.Status == true)
            {
                Console.WriteLine("Crurrent Status: User is Active");
            }
            else Console.WriteLine("Crurrent Status: User is InActive");

            Console.WriteLine("Customer Name: " + cust.Cname);


            Console.WriteLine("Balance: "+ cust.Balance);


            // Modifying the name of customer(only status is Active).we can modifiy the name because we have given both get and set to the Cname.
            /*cust.Cname += "Sam Smith";
            Console.WriteLine("Mofified Name: "+cust.Cname);*/

            //withdrawing some balance from user.

            cust.Balance -= 5000;
            Console.WriteLine("Performing Withdraw of 5000....");
            Console.WriteLine("Updated balance : "+cust.Balance);

            //modifying status value to true(Active)

            /*cust.Status = true;

            if (cust.Status == true)
            {
                Console.WriteLine("Crurrent Status: User is Active");
            }
            else Console.WriteLine("Crurrent Status: User is InActive");
*/

            //if user want to withdraw more balance then what he has. It should not be allowed. and old value is printed.

            

            Console.WriteLine("Performing Withdraw 0f 300....");

            cust.Balance = cust.Balance - 300;
            Console.WriteLine("Updated balance: " + cust.Balance);

            Console.WriteLine("Performing Withdraw 0f 200....");

            cust.Balance = cust.Balance - 200;
            Console.WriteLine("Updated balance: " + cust.Balance);

            // if withdraw fails print old value.
            Console.WriteLine("Performing Withdraw 0f 100.... withdraw fail Minimum balance should be more than 500");

            cust.Balance = cust.Balance - 100;
            Console.WriteLine("Updated balance: " + cust.Balance);


            // selecting city from Enum.


            // As set accessor is set to protected for the city only child class can set the value of City.
           /* cust.City = Cities.Hyderabad;*/
            Console.WriteLine("Current City: " + cust.City);

            Console.WriteLine("Updated City: " + cust.City);


            Console.WriteLine("Current State: "+cust.State);
           // As set accessor is set to protected for the State only child class can get the value of State.
           /* cust.State = "Karnataka";*/
           Console.WriteLine("Updated State: " + cust.State);

            Console.WriteLine("Current Country: "+ cust.Country);

            /*cust.Country = "U.S.A";

            Console.WriteLine("Updated Country: "+cust.Country);*/

            Console.WriteLine("New Country: " + cust.County2);
            Console.ReadLine();
        }
    }
}
