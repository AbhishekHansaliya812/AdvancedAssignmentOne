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
            Console.WriteLine("Company : Ford");
        }
    }

    /* Derived Class */
    public class ModelOne : HierarchicalInheritance
    {
        /* Method of Derived Class */
        public void ModelFirst()
        {
            Console.WriteLine("Model : Mustang");
        }
    }

    /* Derived Class */
    public class ModelTwo : HierarchicalInheritance
    {
        /* Method of Derived Class */
        public void ModelSecond()
        {
            Console.WriteLine("Model : Endeavour");
        }
    }

    /* Driver Class */
    class TestHierarchicalInheritance
    {
        /* Main method */
        static void Main(string[] args)
        {
            /* Creating objects */
            ModelOne modelOne = new ModelOne();
            ModelTwo modelTwo = new ModelTwo();

            /* Calling methods */
            modelOne.Company();
            modelOne.ModelFirst();

            modelTwo.Company();
            modelTwo.ModelSecond();

            Console.ReadKey();
        }
    }
}
