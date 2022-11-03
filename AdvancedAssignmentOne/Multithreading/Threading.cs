using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedAssignmentOne.Multithreading
{
    /* Class for Multithreading */
    public class Threading
    {
        /* First Method for Multithreading */
        public static void MethodOne()
        {
            try
            {
                for (int index = 0; index < 10; index++)
                {
                    Console.WriteLine("MethodOne : " + index);
                }
            }
            catch (System.Exception exceptionOne)
            { 
                Console.WriteLine(exceptionOne.Message);
            }
        }

        /* Second Method for Multithreading */
        public static void MethodTwo()
        {
            try
            {
                for (int index = 0; index < 10; index++)
                {
                    Console.WriteLine("MethodOne : " + index);
                }
            }
            catch (System.Exception exceptionTwo)
            { 
                Console.WriteLine(exceptionTwo.Message);
            }
        }

        /* Third Method for Multithreading */
        public static void MethodThree()
        {
            try
            {
                for (int index = 0; index < 10; index++)
                {
                    Console.WriteLine("MethodOne : " + index);
                    /* Thread gets suspended for 2 seconds */
                    Thread.Sleep(2000);
                }
            }
            catch(System.Exception exceptionThree)
            {
                Console.WriteLine(exceptionThree.Message);
            }
        }
    }
}
