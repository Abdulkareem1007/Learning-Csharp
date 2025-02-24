using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

// Use Abstract Class and Abstract  Methods.

// We Want to develop a applicaton and in that applicaiton we have few Entities.

// Entities: Circle, Rectangle, Triangle, Cone.

// We will define Class representing each entity with attribue for each entity.

// Attributes: 
// Rectangle: Height , width.
// Circle: Radius, Pi.
// Triangle: Height, Base(Width).
// Cone: Radius, Height, Pi. 

// Identify the common Attributes to reduce code and provide code resuability (oops benifits).

// Width , height , radius ,pi are common.

// We need Find the Area of all the figure. every figure above have different formula for finding the area so we cannot defined ot under the common class (Figure).

// This is were we can use the concept of abstraction. because we cannot implement the method in the parent class but we can define in the parent class
//  Then child class can implement it on their own according to thier own formula.

namespace AbstractClassExample
{
    //Common Class for all figures.
    public abstract class Figure
    {
        public double Width, Height, Radius;

        public const float Pi = 3.14f;

        // Abstract Method.
        public abstract double GetArea();

    }

    // Rectangle class inheriting from Figure class.
    public class Rectangle : Figure
    {


        public Rectangle(double Width, double Height)

        {
            //this.Width and this.Height refers to the width inherited from parent class Figure. Width and height refers to the Constructor( instance of the Rectangle class). 
            this.Width = Width;
            this.Height = Height;

            //Finding Area of Rectangle

        }

        public override double GetArea()
        {
            return Width * Height;
        }

    }
    // Triangle class inheriting from Figure class.
    public class Triangle : Figure
    {
        public Triangle(double Height, double Width)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public override double GetArea()
        {
            return Width * Height;


        }
    }
    // Circle class inheriting from Figure class.
    public class Circle : Figure
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public override double GetArea()
        {
            return Pi * (Radius * Radius);

        }
    }
    // Cone class inheriting from Figure class.
    public class Cone : Figure
    {
        public Cone(double Radius, double Height)
        {
            this.Radius = Radius;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return Pi* Radius*(Radius+Math.Sqrt(Height*Height + Radius*Radius));

        }
    }

    class TestFigures
    {
        static void Main(string[] args)
        {
            // Area of Triangle.
            Triangle triangle = new Triangle(15, 10);
            Console.WriteLine("Area Of Triangle is: "+ triangle.GetArea());

            // Area of Rectangle.
            Rectangle rectangle = new Rectangle(20, 10);
            Console.WriteLine("Area Of Rectangle is: " + rectangle.GetArea());

            // Area of Circle.
            Circle circle = new Circle(6.5);
            Console.WriteLine("Area Of Circle is: " + circle.GetArea());


            // Area of Cone.
            Cone cone = new Cone(6.5, 10);
            Console.WriteLine("Area Of Cone is: " + cone.GetArea());

            Console.ReadLine();
        }
    }
}
   