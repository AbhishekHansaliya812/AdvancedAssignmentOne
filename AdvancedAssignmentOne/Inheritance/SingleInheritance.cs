using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Problem Statement : Create one example for single inheritance

*/

namespace AdvancedAssignmentOne
{
    /* Base Class */
    public class SingleInheritance
    {
        /* Method of base class */
        public void Ford()
        {
            try
            {
                Console.WriteLine("Company : Ford");
            }
            catch (System.Exception exceptionOne)
            {
                Console.WriteLine(exceptionOne.Message);
            }
        }
    }

    /* Derived Class */
    public class Vehicle : SingleInheritance
    {
        /* Method of derived class */
        public void Model()
        {
            try
            {
                Console.WriteLine("Model : Mustang");
            }
            catch (System.Exception exceptionTwo)
            {
                Console.WriteLine(exceptionTwo.Message);
            }
        }
    }
}
