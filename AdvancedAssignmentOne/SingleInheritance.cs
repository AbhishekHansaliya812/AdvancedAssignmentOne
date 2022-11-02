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
            Console.WriteLine("Company : Ford");
        }
    }

    /* Derived Class */
    public class Vehicle : SingleInheritance
    {
        /* Method of derived class */
        public void Model()
        {
            Console.WriteLine("Model : Mustang");
        }
    }

    /* Driver Class */
    /*class TestSingleInheritance
    {
        *//* Main method *//*
        static void Main(string[] args)
        {
            *//* Creating object *//*
            Vehicle vehicle = new Vehicle();

            *//* Calling methods *//*
            vehicle.Ford();
            vehicle.Model();

            Console.ReadKey();
        }
    }*/
}
