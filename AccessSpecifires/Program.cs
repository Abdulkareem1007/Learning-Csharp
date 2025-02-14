using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AccessSpecifires

{   // Access Specifires: These are special type of modifires using which we can define the scope of the "Type" and its members.

    // Following are the Access Specifires in CSharp. Each of these Access Specifires have different scope.

    // Private:
    // Private members can only be accessed within the class in which it was defined.
    // The default scope of every member of a class is private.
    // we can not declear Types( Class ) as private.
    // default Scope of the Type( Class ) is Internal.

    // Internal:
    // If a member of a class is declared with Internal it can be accessed by the child class or non child class with in the same project. 
    // ( Example: we cannot Consuming the member of the class from the child class present or from non-child in different project)
    // default Scope of the Type( Class ) is Internal.

    // Protected:
    // member declared as protected can be accessed within the class in which it is defined in as well as child class.
    // we can not declear Types(Class ) as protected.
    // default Scope of the Type( Class ) is Internal.


    // Protected Internal:
    // It is a combination of Protected and Internal If Protected or internal any of these two are accessable Protected internal also be accessible.
    // we can not declear Types( Class ) as protected internal.
    // default Scope of the Type( Class ) is Internal.

    // Private protected: 
    // Member declear with private protected can accessed either within the same class or by child class with in the same project.

    // Public:
    // we can from any where or any class not restrections
    // we can only declear Types(Class ) as public and Internal.
    // default Scope of the Type( Class ) is Internal.

    // If public Access specifires is use then the Class or members can be Access from any where.
    public class Program
    {
        // we are declearing each of these Acces Specifires by creating the methods:
        
        // Note:- A member of a class that is  define with any Access specifire will be accessible in the class.
        // Ristraction will start to happen outside the Class.
         
        private void Test1()
        {
            Console.WriteLine("This is Test1 Private Method");
        }

        internal void Test2()
        {
            Console.WriteLine("This is Test2 Internal Method");
        }

        protected void Test3()
        {
            Console.WriteLine("This is Test3 Protected Method");
        }

        protected internal void Test4()
        {
            Console.WriteLine("This is Test4 Protected Internal Method");
        }

        private protected void Test5()
        {
            Console.WriteLine("This is Test5 private Protectet Method");
        }

        public void Test6()
        {
            Console.WriteLine("This is Test5 public Method");
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            // We can call all the methods present in the Same class.

           //Case 1: // Consuming member of a class from the same class.
            p.Test1();
            p.Test2();
            p.Test3();
            p.Test4();
            p.Test5();
            p.Test6();

            Console.ReadLine(); 
        }


        // Summary:
        // Case 1: Consuming members of a class Program from same class.
        // Case 2: Consuming members of a class Program from child class of same project.
        // Case 3: Consuming members of a class Program from non-child class of same project.
        // Case 4: Consuming members of a class Program from child class of different project.
        // Case 5: Consuming members of a class program from the non-child class of different project.


        /*
            CASES     PRIVATE   INTERNAL    PROTECTED   PROTECTED INTERNAL  PRIVATE PROTECTED   PUBLIC         
            
            Case 1:    YES        YES          YES           YES                  YES           YES

            Case 2:    NO         YES          YES           YES                  YES           YES

            Case 3:    NO         YES          NO            YES                  NO            YES

            Case 4:    NO         NO           YES           YES                  NO            YES

            Case 5:    NO         NO           NO            NO                   NO            YES

         */






    }
}
