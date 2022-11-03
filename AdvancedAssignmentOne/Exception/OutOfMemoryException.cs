using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedAssignmentOne.Exception
{
    /* Class for OutOfMemoryException */
    public class OutOfMemoryException : SystemException
    {
        /* Method for increasing length of StringBuilder object */
        public void OutOfmemory()
        {
            /* StringBuilder object */
            StringBuilder stringBuilder = new StringBuilder(15, 15);
            /* Appending string to string builder object */
            stringBuilder.Append("Substring #1 ");

            /* try block - Inserting string in StringBuilder object */
            try
            {
                stringBuilder.Insert(0, "Substring #2 ", 1);
            }
            /* catch block - print exception message */
            catch (OutOfMemoryException outOfMemory)
            {
                Console.WriteLine(outOfMemory.Message);
            }
            /* finally block */
            finally
            {
                Console.WriteLine("This is Finally Block");
            }
        }
    }
}
