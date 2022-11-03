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
            try
            {
                Console.WriteLine("Hello " + name);
            }
            catch(System.Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
