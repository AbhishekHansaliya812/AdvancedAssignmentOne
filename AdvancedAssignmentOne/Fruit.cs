using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Problem Statement : Create Interface for Fruits and implement method in different fruits. Then print name and colour of that fruits.

*/

namespace AdvancedAssignmentOne
{
    /* Interface */
    public interface IFruit
    {
        /* Interface method */
        void Details();
    }

    /* Derived Class */
    public class Apple : IFruit
    {
        /* Implimentation of interface method */
        public void Details()
        {
            Console.WriteLine("Fruit : Apple\tColor : Red");
        }
    }

    /* Derived Class */
    public class Banana : IFruit
    {
        /* Derived Class */
        public void Details()
        {
            Console.WriteLine("Fruit : Banana\tColor : Yellow");
        }
    }

    /* Driver Class */
    public class PrintFruitDetails
    {
        /* Main method */
        static void Main(string[] args)
        {
            /* Creating object */
            IFruit fruit;

            /* Calling interface method from Apple class */
            fruit = new Apple();
            fruit.Details();

            /* Calling interface method from Banana class */
            fruit = new Banana();
            fruit.Details();

            Console.ReadKey();
        }
    }
}
