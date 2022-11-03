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
