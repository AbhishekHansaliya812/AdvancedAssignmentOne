using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Problem Statement : Create methods for internal access modifier in encapsulation

*/

namespace AdvancedAssignmentOne
{
    /* internal Class */
    class InternalEncapsulation
    {
        /* internal field */
        internal string company = "Advanced";

        /* internal method */
        internal void Message(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }

    /* Driver Class */
    /*class TestInternalEncapsulation
    {
        *//* Main method *//*
        static void Main(string[] args)
        {
            *//* Creating object *//*
            InternalEncapsulation testInternal = new InternalEncapsulation();

            *//* Calling field *//*
            Console.WriteLine("Hello " + testInternal.company);

            *//* Calling method *//*
            testInternal.Message("Abhishek Hansaliya");
            Console.ReadKey();
        }
    }*/
}
