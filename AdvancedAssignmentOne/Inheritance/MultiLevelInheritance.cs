using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Problem Statement : Create one example for Multilevel inheritance

*/

namespace AdvancedAssignmentOne
{
    /* Base Class */
    public class MultiLevelInheritance
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

    /* Derived Class for MultiLevelInheritance class and Base Class for CarColor Class */
    public class Car : MultiLevelInheritance
    {
        /* Method */
        public void Model()
        {
            try
            {
                Console.WriteLine("Model : Mustang");
            }
            catch(System.Exception exceptionTwo)
            {
                Console.WriteLine(exceptionTwo.Message);
            }
        }
    }

    /* Derived Class */
    public class CarColor : Car
    {
        /* Method of Derived class */
        public void Color()
        {
            try
            {
                Console.WriteLine("Colror : Black");
            }
            catch (System.Exception exceptionThree)
            {
                Console.WriteLine(exceptionThree.Message);
            }
        }
    }
}
