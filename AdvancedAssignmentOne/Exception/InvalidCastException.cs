using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedAssignmentOne.Exception
{
    /* Class for InvalidCastException */
    public class InvalidCastException : SystemException
    {
        /* Method to convert from boolen to char */
        public void InvalidCast()
        {
            /* Declaration of Variable */
            bool flag = true;

            /* try block - convert boolen to char */
            try
            {
                IConvertible convert = flag;
                Char character = convert.ToChar(null);
                Console.WriteLine("Conversion succeeded.");
            }
            /* catch block - print exception message */
            catch (InvalidCastException invalidCast)
            {
                Console.WriteLine(invalidCast.Message);
            }
            /* finally block */
            finally
            {
                Console.WriteLine("This is Finally Block");
            }
        }
    }
}
