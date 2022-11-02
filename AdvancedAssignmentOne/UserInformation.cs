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
            Console.WriteLine("First name : {0}",firstName);
            Console.WriteLine("Last name : {0}",lastName);
        }

        /* Defining method to print city */
        public void Print(string city)
        { 
            Console.WriteLine("City : {0}",city);
        }

        /* Defining method to print mobile number and email */
        public void Print(long mobileNumber, string email)
        {
            Console.WriteLine("Mobile number : {0}", mobileNumber);
            Console.WriteLine("Email : {0}", email);
        }

        /* Main Method */
        /*static void Main(string[] args)
        {
            *//* Creating object *//*
            UserInformation userInformation = new UserInformation();

            *//* Calling method with parameters Abhishek and Hansaliya *//*
            userInformation.Print("Abhishek", "Hansaliya");

            *//* Calling method with parameter Rajkot *//*
            userInformation.Print("Rajkot");

            *//* Calling method with parameters 9408039142 and abhishek.hansaliya@oneadvanced.com *//*
            userInformation.Print(9408039142, "abhishek.hansaliya@oneadvanced.com");

            Console.ReadKey();
        }*/
    }
}
