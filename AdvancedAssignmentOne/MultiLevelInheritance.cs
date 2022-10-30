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
            Console.WriteLine("Company : Ford");
        }
    }

    /* Derived Class for MultiLevelInheritance class and Base Class for CarColor Class */
    public class Car : MultiLevelInheritance
    {
        /* Method */
        public void Model()
        {
            Console.WriteLine("Model : Mustang");
        }
    }

    /* Derived Class */
    public class CarColor : Car
    {
        /* Method of Derived class */
        public void Color()
        {
            Console.WriteLine("Colror : Black");
        }
    }

    /* Driver Class */
    class TestMultiLevelInheritance
    {
        /* Main method */
        static void Main(string[] args)
        {
            /* Creating object */
            CarColor vehicle = new CarColor();

            /* Calling methods */
            vehicle.Ford();
            vehicle.Model();
            vehicle.Color();

            Console.ReadKey();
        }
    }
}
