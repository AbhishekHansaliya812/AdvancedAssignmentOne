using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedAssignmentOne.Exception
{
    /* Class for NullReferenceException */
    public class NullReferenceException : SystemException
    {
        /* Method for NullReferenceException */
        public void NullReference()
        {
            /* try block */
            try
            {
                int[] values = null;
                for (int index = 0; index <= 9; index++)
                    values[index] = index * 2;

                foreach (var value in values)
                    Console.WriteLine(value);
            }
            /* catch block - print exception message */
            catch (NullReferenceException nullRefrence)
            {
                Console.WriteLine("Hello");
                Console.WriteLine(nullRefrence.Message);
            }
            /* finally block */
            finally
            {
                Console.WriteLine("This is Finally Block");
            }
        }
    }
}
