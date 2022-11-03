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
            try
            {
                Console.WriteLine("Fruit : Apple\tColor : Red");
            }
            catch (System.Exception exceptionOne)
            {
                Console.WriteLine(exceptionOne.Message);
            }
        }
    }

    /* Derived Class */
    public class Banana : IFruit
    {
        /* Derived Class */
        public void Details()
        {
            try
            {
                Console.WriteLine("Fruit : Banana\tColor : Yellow");
            }
            catch (System.Exception exceptionTwo)
            {
                Console.WriteLine(exceptionTwo.Message);
            }
        }
    }
}
