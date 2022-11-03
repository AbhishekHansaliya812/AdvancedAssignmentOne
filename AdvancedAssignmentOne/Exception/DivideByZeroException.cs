using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedAssignmentOne.Exception
{
    /* Class for DivideByZeroException */
    public class DivideByZeroException : SystemException
    {
        /* Method for DivideByZeroException */
        public void DivideByZero()
        {
            /* Declaration of Variable */
            int number1 = 3000;
            int number2 = 0;

            /* try block - divide number */
            try
            {
                Console.WriteLine(number1 / number2);
            }
            /* catch block - print exception message */
            catch (DivideByZeroException divideByZero)
            {
                Console.WriteLine(divideByZero.Message);
            }
            /* finally block */
            finally
            {
                Console.WriteLine("This is Finally Block");
            }
        }
    }
}
