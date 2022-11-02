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
            Console.WriteLine("This is Default Constructor");
        } 
    }

    /* Class for Parameterized Constructor*/
    public class Parameterized
    {
        /* Parameterized Constructor */
        public Parameterized(string typeOfConstructor)
        {
            Console.WriteLine("This is " + typeOfConstructor);
        }
    }

    /* Driver Class */
    /*class TestConstructor
    {
        *//* Main method *//*
        static void Main(string[] args)
        {
            *//* "_" is discard, its a placeholder for variables that are unused *//*
            _ = new Constructor();
            _ = new Parameterized("Parameterized Constructor");

            Console.ReadKey();
        }
    }*/
}
