using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace VariablesOFClass
{

    // A Class can have following types of variables.

    // 1) static :- If a variable is decleared with static keyword then it is a static vaiable other wise it a non static(instance) vatiable.
    //              there is another way to declear the static variable if a varibale is declear inside any static block then it is a static variable.
    //              if we want to consume or print the value of a static variable in our main method we can directly use it example Console.Write("Value of y"+ y);
    //              we dont need to create an instance to use the static variables.Because a static variable is initilized immiditely after execution of the class starts.
    //              
    //      Note: - (Life of a class means starting and end of the executin of the class ).
    //              In the life cycle of the class a static variable is initilized one and only one time.
    //              where as the non static is initilized 0 time when no instance is created and N times when N instance is created.

    


    // 2) Non Static:- we we declear any variable in the class by defaut it is a non static variable unless we explicitly declear it as static.
    //                 To use the static variable we need to create the instance of the class. it is because the memory is only allocated when we create instance of the class.
    //              
    //      Note:- instance variable is associated with instance creation and constructor calling. so instance variable can be initialized thru the constructor also.

    // 3) constants:- when a variable is decleared with const keyword then we call it as constant variable and these constant variable cannot be modified once they are decleared.
    //                 So it is must to initialize a Constant variables at the time of declaeration.
    //                  Constant varaibles will also have one and only one copy like static variables. an it initilized once the execution of the class starts. we cannot modifiy the value of constant variables after declearation.
    //                  it also doesnot requires to created instance of the class to use Constant.
    //
    // 4) readonly:- If a variable is decleared by using readonly keyword it is a readonly variable these variables also cannot be modified like constants.
    //               The difference between constant variable and readonly varibale is that constant variable cannot be modified after declearation and readonly variables cannot be modified after initilization.
    //               It is not compulsory to initialize a readonly variable at the time of declaration they can be initialize under the constructor.
    //               The readonly variable behave like non static variables N number od instance will have N number of readonly variable copy.
     class Program
    {
        int x = 10; // non static varibale or instance varible.

        static int y = 20; // static variable.

        const float PI = 3.14f; // constant variable f is suffix for the float.
        readonly bool flag;
        // non parametrized constructor.
        public Program()
        {
            x = 10; 
        }
        // this is a parametrized constructor.
        public Program(int x,bool flag)
        {
            this.x=x;
            this.flag = flag;
        }

        static void Main(string[] args)
        {

            int z = 50;  // z is also a static variable as it is decleared inside a static block.

            Console.WriteLine("Value of static variable y: "+y); // noo need to careate instance to use this variable. because as soon as the execution starts the memory of static variable is created and y is initilized.

            Console.WriteLine("Value of PI is : " + PI);
            Console.WriteLine("Variable of varibale z: "+z);


            // to use non staic variable x we need to careate a instance of the class. Because the memory is only allocated after the instance is created.

            Program p1 = new Program();

            Program p2 = new Program(110,false);

            p1.x = p1.x + 33;
            Console.WriteLine("The value of Non static variable x of p1 instance: " + p1.x);

            // changing in the variable x is p1 instance will not change the value of x in p2 instance as both are saperate copy.
            Console.WriteLine("The value of Non static variable x pf p2 instance: " + p2.x+ " flag : "+p2.flag);

            // initilizing the instance variable (non static ) by using constructors.

            Program p3  = new Program(70,true);
            
            Console.WriteLine("Value of the x for the instance p3: "+p3.x +" flag : "+p3.flag ); 
            
            
            // Summary: 

            // 1) Instance variable(Non static variables): It maintains one copy for each instance of the class created and initailizes only the the instance is created.
            //                                              if we create N instance N copy 0 instance 0 copy will be there.

            // 2) static variables: Maintains one value for the whole class and can be mofidified. It will have only one copy, initializes one and only one time.


            // 3) Constant variables: These variables cannot be modified after declearation.we must have assign the value at the time of declearation only.
            //                         It maintains one and only one copy through out the life cycle of the class.

            // 4) readonly variables: These variables cannot be modified after the initialization.it maintians a copy for each instances.N instances N copy 0 instance 0 copy.
                                            
        }
    }
}
