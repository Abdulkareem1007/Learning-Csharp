using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

// Delegates: It is a type safe fucntion pointer. it means that delegate is going to hold the reference of a method and it going to call the method for execution.

// A delegate holds a reference of a method and then it calls the method for execution.

// In C# we are calling the method by creacting a instance of a class when it is a non static method. And calling with the class name if it is a static method.
// The second way to call the method is by using delegates.

// Note: A delegate is a user defined type.and all the types are defined under a namespace. A namespace is a logical container of the types.
        // that is why we define delegates directly under a namespace.

// To call a method using delegate we have 3 steps:-

    // 1) Define a delegate: To degine a delegate: [<modifiers>] delegate void/type <Name> ([parameter list]).
    //    example: public delegate void AddDelegate(int a,int b);
    //    delegate is defined under a namespace.
  
    // 2) Instantiation a Delegate: It is a process of creating instance of the delegate. As delegate is a user define type (reference type) we need to create instance of the delegate.
                                    // At the time of creating instance of delegate we need to pass method name as a parameter to the delegate.
                                    // Example: AddDelegate addDe = new AddDelegate(AddNums)

    // 3) Now Call the delegate by passing required parameter values, so that internally the method which is bound with the delegate get executed. 

    // Note: return type of the delegate should be exactly same as return type of the method.
    //       The parameter type should be same as the method parameter type. parameter names can be different.
    //       That is why we say a delecate is a type safe function pointer.
namespace Delegates
{
    // step 1: defining a delegate.

    public delegate void AddDelegate(int x, int y);

    public delegate string SayDelegate(string name);
    internal class Program
    { 

        public void AddNums(int a,int b)
        {
            Console.WriteLine("Sum: " + (a+b));
        }

        //static method.
        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
        static void Main(string[] args)
        {

            Program program = new Program();    

            // calling AddNum by creating instance of Class Program.
            program.AddNums(50,20);

            //SayHello is a static method so no need to create instance.Insted use class name.methodname() to call the method.
            string str = Program.SayHello("John");

            Console.WriteLine(str);

            // Step 2: 

            // Crating instance of a delegate.
            // we need to write ( instance.methodname() )program.AddNums because AddNums is a non static method and we cannot access non static method from static block directly.
            // new below statement the address of the method is given to the delegate.
            AddDelegate AddDlg = new AddDelegate(program.AddNums);

            // creating instance of delegate fro another method.
            // as SayHello is a static method and a static method can be direclty access in a static block in same class. for other class we should prefix it with the class Name.
            SayDelegate SayDlg = new SayDelegate(Program.SayHello);

            // step 3: Calling the delegate with required parameter to execute the method.

            AddDlg(50, 40);
            // or we can call the delecate as method
            AddDlg.Invoke(20, 20);

            string str2 =  SayDlg("Smith");
            Console.WriteLine(str2);
            // or we can call the delecate as method
            string str3 = SayDlg.Invoke("Mike");
            Console.WriteLine(str3);

            Console.ReadLine();

        }
    }
}
