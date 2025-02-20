using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Operator Overloading:

// It is also an approach of defining multiple behaviour to an operator
// and those behaviour will vary based on the operand types between which the operator is used.

//For Example "+" is an addition aopeator when used between two numeric operands.
//and it is an concatenation when it is used between two string operands.

// Number + Number => addition.
// string + string => concatenation.

// To Perform +,-,*,<,>,!=,==, etc we have operator method defined in our base class library.
// we can also define Operator method of our own to perform operation between two operands.
// Syntax for operator method: 

// [<modifires>] static <return type> operator <opt> (<operand types>)
// {-- logic }
//  method must be static return type should be same as what we are expecting from operands, operator (opt should be what we want to perform between operands)

// suppose if we want to write a operator method to add two matrix just like we are adding two number num3 = num1+num2. we need to define it in Martix class.

// public ststic Matrix operator +(Matrix obj1, Matrix obj2)



// Method Overloading : It an approach of defining multiple behaviours to a method and those behaviours will vary based on parameters od the method.

// Example:
// 
// String str = "Hello how are you";

// str.Substring(14); => you. (starting index to the end character).
// str.Substring(10); => are you. (strating index to the end character).
// str.Substring(10,3) => are. (Starting index to number of character defined be second parameter).




namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
