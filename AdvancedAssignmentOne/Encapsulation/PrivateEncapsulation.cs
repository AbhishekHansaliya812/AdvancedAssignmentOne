using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Problem Statement : Create methods for private access modifier in encapsulation

*/

namespace AdvancedAssignmentOne
{
    /* Driver class */
    class PrivateEncapsulation
    {
        /* private field */
        private string company = "Advanced";

        /* private method */
        private void Message(string name)
        {
            try
            {
                Console.WriteLine("Hello " + name);
            }
            catch(System.Exception exceptionOne)
            {
                Console.WriteLine(exceptionOne.Message);
            }
        }

        /* Main method */
        /*static void Main(string[] args)
        {
            try
            {
                *//*Creating object*//*
                PrivateEncapsulation testPrivate = new PrivateEncapsulation();

                *//*Calling field*//*
                Console.WriteLine("Hello " + testPrivate.company);

                *//*Calling method*//*
                testPrivate.Message("Abhishek Hansaliya");
                Console.ReadKey();
            }
            catch (System.Exception exceptionTwo)
            {
                Console.WriteLine(exceptionTwo.Message);
            }
        }*/
    }
}
