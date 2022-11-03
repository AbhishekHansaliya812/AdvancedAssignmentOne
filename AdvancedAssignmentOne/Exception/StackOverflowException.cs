using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedAssignmentOne.Exception
{
    /* Class for StackOverflowException */
    public class StackOverflowException : SystemException
    {
        /* Method to increase value of parameter by one */
        public void StackOverFlow(int equals)
        {
            Console.WriteLine(equals);
            StackOverFlow(++equals);
        }
    }
}
