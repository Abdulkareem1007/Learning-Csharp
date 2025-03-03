using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// If a class is an Entity then every attribute of an entity is a property of a class. 
// In Real world a We define classes to Represent Entity each Entity have a set of attributes.

// Suppose in an application we an Entity called customer.

// Customer have following attributes: 
// CustId.
// Status.
// Cname.
// Balance.

//Conslusion: Why do we use property to give get and set access to the varaible insted of using public variable is because. 
//            when we use public variable we cannot write any block of code to controll the access of the variable. while use property we can write block of code to controll the get and set access to the variable.


// We can also define a property with out a field or variable.
// The concept is called Auto-Implemented or Automatic Property.

// Automatic Propert is a property that is defined without a field(Variable).

namespace PropertiesDemo2
{
    internal class Customer
    {
        //class fields(variables)
        int _CustId;
        bool _Status;
        string _Cname,_State;
        Cities _City;

        double _Balance;

        //defining a parametrized constructor to initilizes the value.
        public Customer(int CustId , bool Status,string Cname,double Balance,Cities City,string State,string Country)
        {
            _CustId = CustId;
            _Status = Status;   
            _Cname = Cname; 
            _Balance = Balance;
            _City = City;
            _State = State;

            // As we doent know the implicit variable name in Automatic property we can use assign property to the parameter.
            // here this.Country is the  property and the other Country is the parameter.
            this.Country = Country;
        }

        //defining a property to access CustId.
        public int CustId
        {
            get { return _CustId; }
        }
        //defining a property to access(getting) and setting Status.
        public bool Status
        {
            get { return _Status; }
            
            set { _Status = value; }
        }

        //defining a property for getting and setting Cname.
        public string Cname
        { 
            get { return _Cname; } 

            //Adding condition if status is active then only we can perform modification.
            set
            {
                if (_Status == true)
                    _Cname = value;
            }        
        }
        //defining a property for getting and setting Balance.
        public double Balance
        {
            //If User is Inactive the balance should be zero.
            
            get
            {
               /* if (_Status == true)*/
                    return _Balance;
/*                else return 0;*/
            }

               // If User is Inactive the balance we can not modify the balance.
            set
            {   if (_Status == true)
                //if minimum balance is more then 500 then only Withdraw should be allowed.
                {
                    if (value >= 500)
                        _Balance = value;
                }
                else
                    _Balance = 0;
            } 
        }

        // Defining a property for the Cities Type which is a user define type and a enum.

        // we can also provide access modifiers to the accessors to every one from setting the value.

        // Suppose if we want that only set Child class is allowed to set the value we can use protected modifier to the set accessor.
        public Cities City
        {
            get { return _City; }

            //only child class are are allow to set the value.
            protected set
                      {
                        if (_Status == true)
                         _City = value;
                      }

        }

        // Property for State.

        public string State
        { 
            get { return _State; }
            //only child class are are allow to set the value.
            protected set 
                      { 
                         if(_Status == true)
                          _State = value;
                      } 
        }

        // Automatic Property.
        // introduced in 3.0 version of C#
        // it doesnot contain any statments in get and set accessors.
        // it will have a implicit varibale to store the value.
        // we can use this Auto-Implemented Property Only if there is no Condition block int the set and get accessor.
        public string Country
        {
            get;
            set;
        }


        // if the property value is fixed and it is not going to chanhe then we can use auto property inililizer we done need to write parameter and also no need to inililize the property in the constructor.
        // introduced in 6.0 version of C#
        public string County2
        { get; set; } = "USA";
        static void Main(string[] args)
        {
        }
    }
}
