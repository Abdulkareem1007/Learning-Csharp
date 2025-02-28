using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Structure is also user defined Type. 
// Structure in C# can contain most of the members that a class can contains.
// Like Fields, Methods, Constructors, Properties, Indexers, Operator Methods etc.

// Syntax: [<Access Modifires>] struct <Name> { -- define members here. }

// To add a structure in our project. right click on project ==> add new item ==> select a code file from the menu.
//  After selecting and renaming code file hit enter. The code file will be empty. we need to import all the namespaces.


// Difference between Class and structure.

// 1. Class is a reference type where as structure is a value type. 

// 2. Memory allocation for instances of class is peroform on Managed Heap where as memory allocated for instances of structure is performed on stack.

// 3. We use class for representing an entity with larger volumes of data where as we use structure for representing smaller volume of data.

// 4. In Case of class "new" keyword is mandatory for creating the instance of class where as in case of structue it is optional.

// 5. Fileds(Variables) of a class can be initilized while we are declaring the class but in Structures we cannot initilized the variable at the time of declaration.
//    In structure either we can initilized fields through the consturctors or after creating instance we can initilize it.

// 6. We can define any constructor in class that is parameterized or parameter less and if no constructor is defined then there will be implicit constructor(default).
//    Where as in Structure  parameter less or default constructor is always implicit we cannot define it explicitly again. We can only define Parameterized Constructor.

// 7. Inside a class if we define "zero" constructor after compilation we will have "one" constructor (Default constructor defined Implicitly) and if we define "N" constructor we will have "N" constructor only
//    because Implicit constructor will not be defined if we explicitly define a constructor inside a class.
//    Where as in structre If we define "zero" constructor after compilation  we will have "one" constructor and if we define "N" constructor then we will have "N+1" constructor. that is a default constructor or parameter less constructor defined implicitly.

// 8. Class Can be inhertied by other classes where as structure cannot be inherited by other structures because structure doesnot support inheritance.

// 9. A class can implement interface same as that a structure can also implement an interface.


//Note: If the Structure constins any fields then we need to initialize those fields ether by explicitly calling the default constructor with "new",
//      Or else if we are not using "new " for creating the instance we need to expilicitly assign value to the filed reffering it thru the instance and assign values.
//

//Note:  All the Pre-defined data types under the libraries of our language which comes under reference type category E.g: String and Object are classes
//       where as all the Pre-Defiend data types that comes under value types category E.g: int(Int32), float(Single), bool(Boolean) are Structures.



namespace Structures
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
        }
    }
}
