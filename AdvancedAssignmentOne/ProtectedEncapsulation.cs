using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Problem Statement : Create methods for protected access modifier in encapsulation

*/

namespace AdvancedAssignmentOne
{
    /* Base Class */
    class ProtectedEncapsulation
    {
        /* protected field */
        protected string company = "Advanced";

        /* protected method */
        protected void Message(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }

    /* Driver Class / Derived Class */
    /*class TestProtectedEncapsulation : ProtectedEncapsulation
    {
        *//* Main method *//*
        static void Main(string[] args)
        {
            *//* Creating object *//*
            TestProtectedEncapsulation testProtected = new TestProtectedEncapsulation();

            *//* Calling field *//*
            Console.WriteLine("Hello " + testProtected.company);

            *//* Calling method *//*
            testProtected.Message("Abhishek Hansaliya");
            Console.ReadKey();
        }
    }*/
}
