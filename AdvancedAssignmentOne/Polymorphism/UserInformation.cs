using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Problem Statement : Print Firstname, Lastname, City, Mobile number, Email using Static polymorphism

*/

namespace AdvancedAssignmentOne
{
    /* Driver Class */
    public class UserInformation
    {
        /* Defining method to print first name and last name */
        public void Print(string firstName, string lastName)
        {
            try
            {
                Console.WriteLine("First name : {0}", firstName);
                Console.WriteLine("Last name : {0}", lastName);
            }
            catch (System.Exception exceptionOne)
            { 
                Console.WriteLine(exceptionOne.Message);
            }
        }

        /* Defining method to print city */
        public void Print(string city)
        {
            try
            {
                Console.WriteLine("City : {0}", city);
            }
            catch (System.Exception exceptionTwo)
            {
                Console.WriteLine(exceptionTwo.Message);
            }
        }

        /* Defining method to print mobile number and email */
        public void Print(long mobileNumber, string email)
        {
            try
            {
                Console.WriteLine("Mobile number : {0}", mobileNumber);
                Console.WriteLine("Email : {0}", email);
            }
            catch (System.Exception exceptionThree)
            { 
                System.Console.WriteLine(exceptionThree.Message);
            }
            
        }
    }
}
