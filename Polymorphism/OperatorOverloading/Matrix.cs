using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    internal class Matrix:Object
    {

        int a, b, c, d;

        // Method to add two matrices. 

        // we are overriding the Tostring method to dispay out materix values.

        public override string ToString()
        { 

            // to print values into materix foramt.
            return a + " " +b +"\n"+c + " " +d+"\n"; 
        }
        public static Matrix operator +(Matrix obj1, Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d);
            return obj;
        }

        public static Matrix operator -(Matrix obj1, Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a - obj2.a, obj1.b - obj2.b, obj1.c - obj2.c, obj1.d - obj2.d);
            return obj;
        }


        public Matrix(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
    }

    class TestMatrix
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(20, 18, 16, 14);
            Matrix m2 = new Matrix(10, 8, 4, 4);

            // to use '+' between matrices we need to define operator method that take two matrices as parameter and return addition of two Matrices.
            
            Matrix m3 = m1+m2;
            Matrix m4 = m1-m2;

            // simple Console.WriteLine method will not display the result.
            // as we are passig m1,m2,m3,m4 which is a Materix type.
            // Internally Console.WriteLine is taking object as an input in palce of value.
            // and then value is converted into Tostring.
            // when we pass instance of a class(m3) it will store the name of the class in it and convert it into string and then it dispaly the output as the name of the class.

            // to get out desire output we can override the to string method so that when we pass the instance of the class in Console.WriteLine() it will display the output.

            Console.WriteLine("Materix 1: ");
            Console.WriteLine(m1);
            Console.WriteLine("Materix 2: ");
            Console.WriteLine(m2);

            Console.WriteLine("Materix Sum: ");
            Console.WriteLine(m3);
            Console.WriteLine("Materix Sub: ");
            Console.WriteLine(m4);
        }

    }
}
