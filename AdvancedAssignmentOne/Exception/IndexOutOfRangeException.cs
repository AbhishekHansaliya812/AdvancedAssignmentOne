using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedAssignmentOne.Exception
{
    /* Class for IndexOutOfRangeException Exception */
    public class IndexOutOfRangeException : SystemException
    {
        /* Declaration of array */
        public int[] array = {0, 1, 2, 3, 4, 5};

        /* Method to print array */
        public void PrintArray()
        {
            /* try block - print array */
            try
            {
                for (int index = 0; index < (array.Length + 1); index++)
                {
                    Console.WriteLine(array[index]);
                }
            }
            /* catch block - print exception message */
            catch (System.IndexOutOfRangeException indexOutOfRange)
            {
                Console.WriteLine(indexOutOfRange.Message);
            }
            /* finally block */
            finally
            {
                Console.WriteLine("This is Finally Block");
            }
        }
    }
}
