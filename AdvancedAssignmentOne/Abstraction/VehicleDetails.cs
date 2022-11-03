using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Problem Statement : Print different vehicle details using Abstraction

*/

namespace AdvancedAssignmentOne
{
    /* Abstract Class */
    public abstract class VehicleDetails
    {
        /* Defining abstarct method */
        public abstract void Details();
    }

    /* Derived Class */
    public class Company : VehicleDetails
    {
        /* implimentation of abstract method */
        public override void Details()
        {
            try
            {
                Console.WriteLine("Company : Ford");
            }
            catch(System.Exception exceptionOne)
            {
                Console.WriteLine(exceptionOne.Message);
            }
        }
    }

    /* Derived Class */
    public class Model : VehicleDetails
    {
        /* implimentation of abstract method */
        public override void Details()
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
    public class Color : VehicleDetails
    {
        /* implimentation of abstract method */
        public override void Details()
        {
            try
            {
                Console.WriteLine("Color : Black");
            }
            catch(System.Exception exceptionThree)
            {
                Console.WriteLine(exceptionThree.Message);
            }
        }
    }
}
