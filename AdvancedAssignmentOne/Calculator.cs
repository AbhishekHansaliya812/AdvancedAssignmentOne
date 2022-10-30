using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Problem Statement : Create two interface and illustrate how to use multiple inheritance in C#

*/

namespace AdvancedAssignmentOne
{
    /* Interface Addition*/
    public interface IAddition
    {
        /* Interface method Addition*/
        int Addition(int firstValue, int secondValue);
    }

    /* Interface Subtraction*/
    public interface ISubtraction
    {
        /* Interface method Subtraction*/
        int Subtraction(int firstValue, int secondValue);
    }

    /* Interface Multiplication*/
    public interface IMultiplication
    {
        /* Interface method Multiplication*/
        int Multiplication(int firstValue, int secondValue);
    }

    /* Interface Division*/
    public interface IDivision
    {
        /* Interface method Division*/
        int Division(int firstValue, int secondValue);
    }

    /* Class deriving all interface to implement multiple inheritance */
    class Calculator : IAddition, ISubtraction, IMultiplication, IDivision
    {
        /* Declaration of Variable */
        public int resultOfAddition;
        /* Implimentation of interface method */
        public int Addition(int firstValue, int secondValue)
        {
            return resultOfAddition = firstValue + secondValue;
        }

        /* Declaration of Variable */
        public int resultOfSubtraction;
        /* Implimentation of interface method */
        public int Subtraction(int firstValue, int secondValue)
        {
            return resultOfSubtraction = firstValue - secondValue;
        }

        /* Declaration of Variable */
        public int resultOfMultiplication;
        /* Implimentation of interface method */
        public int Multiplication(int firstValue, int secondValue)
        {
            return resultOfMultiplication = firstValue * secondValue;
        }

        /* Declaration of Variable */
        public int resultOfDivision;
        /* Implimentation of interface method */
        public int Division(int firstValue, int secondValue)
        {
            return resultOfDivision = firstValue / secondValue;
        }
    }

    /* Driver Class */
    class Calculation
    {
        /* Main method */
        static void Main(string[] args)
        {
            /* Creating object */
            Calculator calculator = new Calculator();

            /* Calling interface methods */
            calculator.Addition(6, 2);
            calculator.Subtraction(7, 3);
            calculator.Multiplication(2, 3);
            calculator.Division(8, 4);

            /* Displaying results */
            Console.WriteLine("Multiple Inheritance using Interfaces.");
            Console.WriteLine("Addition : " + calculator.resultOfAddition);
            Console.WriteLine("Subtraction : " + calculator.resultOfSubtraction);
            Console.WriteLine("Multiplication : " + calculator.resultOfMultiplication);
            Console.WriteLine("Division : " + calculator.resultOfDivision);
            Console.ReadKey();
        }
    }
    
}
