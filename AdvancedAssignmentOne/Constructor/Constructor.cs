using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Problem Statement : Created demo for default and parameterized constructor

*/

namespace AdvancedAssignmentOne
{
    /* Class for Default Constructor*/
    public class Constructor
    {
        /* Default Constructor */
        public Constructor()
        {
            try
            {
                Console.WriteLine("This is Default Constructor");
            }
            catch(System.Exception exceptionOne)
            {
                Console.WriteLine(exceptionOne.Message);
            }  
        } 
    }

    /* Class for Parameterized Constructor*/
    public class Parameterized
    {
        /* Parameterized Constructor */
        public Parameterized(string typeOfConstructor)
        {
            try
            {
                Console.WriteLine("This is " + typeOfConstructor);
            }
            catch(System.Exception exceptionTwo)
            {
                Console.WriteLine(exceptionTwo.Message);
            }
        }
    }
}
