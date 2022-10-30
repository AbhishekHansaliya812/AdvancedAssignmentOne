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
            Console.WriteLine("Hello "+ name);
        }
    }

    /* Driver class */
    class TestPublicEncapsulation
    {
        /* Main method */
        static void Main(string[] args)
        {
            /* Creating object */
            PublicEncapsulation publicEncapsulation = new PublicEncapsulation();

            /* Calling field */
            Console.WriteLine("Hello " + publicEncapsulation.company);

            /* Calling method */
            publicEncapsulation.Message("Abhishek Hansaliya");
            Console.ReadKey();
        }
    }
}
