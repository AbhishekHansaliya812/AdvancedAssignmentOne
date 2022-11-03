using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedAssignmentOne.Exception
{
    /* Class for ArrayTypeMismatchException */
    public class ArrayTypeMismatchException : SystemException
    {
        /* Method for ArrayTypeMismatchException */
        public void ArrayTypeMismatch()
        {
            /* Declaration of Variable */
            string[] names = { "Dog", "Cat", "Fish" };
            Object[] objs = (Object[]) names;

            /* try block - print animal name in objects */
            try
            {
                objs[2] = "Mouse";

                foreach (object animalName in objs)
                {
                    System.Console.WriteLine(animalName);
                }
            }
            /* catch block - print exception message */
            catch (System.ArrayTypeMismatchException arrayTypeMismatch)
            {
                System.Console.WriteLine(arrayTypeMismatch.Message);
            }
            /* finally block */
            finally
            {
                Console.WriteLine("This is Finally Block");
            }
        }
    }
}
