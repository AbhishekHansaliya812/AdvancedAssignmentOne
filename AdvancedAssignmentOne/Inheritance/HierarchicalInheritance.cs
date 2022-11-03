using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Problem Statement : Create one example for hierarchical inheritance

*/

namespace AdvancedAssignmentOne
{
    /* Base Class */
    public class HierarchicalInheritance
    {
        /* Method of Base Class */
        public void Company()
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
    public class ModelOne : HierarchicalInheritance
    {
        /* Method of Derived Class */
        public void ModelFirst()
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

    /* Derived Class */
    public class ModelTwo : HierarchicalInheritance
    {
        /* Method of Derived Class */
        public void ModelSecond()
        {
            try
            {
                Console.WriteLine("Model : Endeavour");
            }
            catch (System.Exception exceptionThree)
            {
                Console.WriteLine(exceptionThree.Message);
            }
            
        }
    }
}
