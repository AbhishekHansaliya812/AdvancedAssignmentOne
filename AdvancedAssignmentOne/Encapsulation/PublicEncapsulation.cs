using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Problem Statement : Create methods for public access modifier in encapsulation

*/

namespace AdvancedAssignmentOne
{
    /* public Class */
    public class PublicEncapsulation
    {
        /* public field */
        public string company = "Advanced";

        /* public method */
        public void Message(string name)
        {
            try
            {
                Console.WriteLine("Hello " + name);
            }
            catch (System.Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }      
        }
    }
}
