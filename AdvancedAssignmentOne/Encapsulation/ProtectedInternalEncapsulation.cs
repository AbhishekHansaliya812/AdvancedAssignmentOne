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
            try
            {
                Console.WriteLine("Hello " + name);
            }
            catch (System.Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            
        }
    }
}
