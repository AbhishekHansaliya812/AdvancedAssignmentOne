using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Problem Statement : Calculate Area of the shape like circle, Square, Reactangle using dynamic polymorphism

*/

namespace AdvancedAssignmentOne
{
    /* Base Class */
    public class ShapeAreaCalculator
    {
        /* Defining methods to calculate area for diferent parameters */
        public virtual void Area(int length) 
        { 
        }

        public virtual void Area(int length, int width)
        { 
        }
    }

    /* Derived Class */
    public class Circle : ShapeAreaCalculator
    {
        public const double PIE = 3.14;

        /* Overriding Method to calculate area of Circle */
        public override void Area(int radius)
        {
            Console.WriteLine("Area of Circle : "+ PIE*radius*radius);
        }
    }

    /* Derived Class */
    public class Square : ShapeAreaCalculator
    {
        /* Overriding Method to calculate area of Square */
        public override void Area(int length)
        {
            Console.WriteLine("Area of Square : " + length*length);
        }
    }

    /* Derived Class */
    public class Rectangle : ShapeAreaCalculator
    {
        /* Overriding Method to calculate area of Rectangle */
        public override void Area(int length, int width)
        {
            Console.WriteLine("Area of Rectangle : " + length * width);
        }
    }

    /* Driver Class */
    class CalculateArea
    {
        /* Main Method */
        static void Main(string[] args)
        {
            /* Declaration of Variables */
            int radius,length,width;

            /* Creating objects */
            ShapeAreaCalculator circle = new Circle();
            ShapeAreaCalculator square = new Square();
            ShapeAreaCalculator rectangle = new Rectangle();

            /* Taking radius of circle as user input and displaying area of circle */
            Console.Write("Enter radius of circle : ");
            radius = Convert.ToInt32(Console.ReadLine());
            circle.Area(radius);

            /* Taking length of square as user input and displaying area of square */
            Console.Write("\nEnter Length of square : ");
            length = Convert.ToInt32(Console.ReadLine());
            square.Area(length);

            /* Taking length and width of rectangle as user input and displaying area of rectangle */
            Console.Write("\nEnter length and width of rectangle : ");
            var userInput = Console.ReadLine().Split(' ');
            length = int.Parse(userInput[0]);
            width = int.Parse(userInput[1]);
            rectangle.Area(length,width);

            Console.ReadKey();
        }
    }
}
