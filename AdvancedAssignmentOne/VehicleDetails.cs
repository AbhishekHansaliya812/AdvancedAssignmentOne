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
            Console.WriteLine("Company : Ford");
        }
    }

    /* Derived Class */
    public class Model : VehicleDetails
    {
        /* implimentation of abstract method */
        public override void Details()
        {
            Console.WriteLine("Model : Mustang");
        }
    }

    /* Derived Class */
    public class Color : VehicleDetails
    {
        /* implimentation of abstract method */
        public override void Details()
        {
            Console.WriteLine("Color : Black");
        }
    }

    /* Driver Class */
    /*public class PrintVehicleDetails 
    {
        *//* Main Method *//*
        static void Main(string[] args)
        {
            *//* Creating object *//*
            VehicleDetails details;

            *//* Calling abstract method of Company class *//*
            details = new Company();
            details.Details();

            *//* Calling abstract method of Model class *//*
            details = new Model();
            details.Details();

            *//* Calling abstract method of Color class *//*
            details = new Color();
            details.Details();

            Console.ReadKey();
        }
    }*/

}
