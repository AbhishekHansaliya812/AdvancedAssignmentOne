using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Problem Statement : Create methods for protected internal access modifier in encapsulation

*/

namespace AdvancedAssignmentOne
{
    /* Class */
    class ProtectedInternalEncapsulation
    {
        /* protected internal field */
        protected internal string company = "Advanced";

        /* protected internal method */
        protected internal void Message(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }

    /* Driver class */
    class TestProtectedInternalEncapsulation
    {
        /* Main method */
        static void Main(string[] args)
        {
            /* Creating object */
            ProtectedInternalEncapsulation testprotectedInternal = new ProtectedInternalEncapsulation();

            /* Calling field */
            Console.WriteLine("Hello " + testprotectedInternal.company);

            /* Calling method */
            testprotectedInternal.Message("Abhishek Hansaliya");
            Console.ReadKey();
        }
    }
}
