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
            try
            {
                Console.WriteLine("Area of Circle : " + PIE * radius * radius);
            }
            catch (System.Exception exceptionOne)
            {
                Console.WriteLine(exceptionOne.Message);
            }
        }
    }

    /* Derived Class */
    public class Square : ShapeAreaCalculator
    {
        /* Overriding Method to calculate area of Square */
        public override void Area(int length)
        {
            try
            {
                Console.WriteLine("Area of Square : " + length * length);
            }
            catch(System.Exception exceptionTwo)
            {
                Console.WriteLine(exceptionTwo.Message);
            }

        }
    }

    /* Derived Class */
    public class Rectangle : ShapeAreaCalculator
    {
        /* Overriding Method to calculate area of Rectangle */
        public override void Area(int length, int width)
        {
            try
            {
                Console.WriteLine("Area of Rectangle : " + length * width);
            }
            catch (System.Exception exceptionThree)
            {
                System.Console.WriteLine(exceptionThree.Message);
            }  
        }
    }
}
