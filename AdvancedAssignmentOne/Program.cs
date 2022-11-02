using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedAssignmentOne
{
    internal class Program : ProtectedEncapsulation
    {
        static void Main(string[] args) 
        {
            /* Assignment Question 1 */

            Console.WriteLine("-------------------- Assignment Question 1 --------------------\n");

            /* Declaration of Variables */
            int radius, length, width;

            /* Creating objects */
            ShapeAreaCalculator circle = new Circle();
            ShapeAreaCalculator square = new Square();
            ShapeAreaCalculator rectangle = new Rectangle();

            /* Taking radius of circle as user input and displaying area of circle */
            Console.Write("Enter radius of circle : ");
            radius = Convert.ToInt32(Console.ReadLine());
            circle.Area(radius);

            /* Taking length of square as user input and displaying area of square */
            Console.Write("\nEnter Length of square : ");
            length = Convert.ToInt32(Console.ReadLine());
            square.Area(length);

            /* Taking length and width of rectangle as user input and displaying area of rectangle */
            Console.Write("\nEnter length and width of rectangle : ");
            var userInput = Console.ReadLine().Split(' ');
            length = int.Parse(userInput[0]);
            width = int.Parse(userInput[1]);
            rectangle.Area(length, width);


            /* Assignment Question 2 */

            Console.WriteLine("-------------------- Assignment Question 2 --------------------\n");

            /* Creating object */
            UserInformation userInformation = new UserInformation();

            /* Calling method with parameters Abhishek and Hansaliya */
            userInformation.Print("Abhishek", "Hansaliya");

            /* Calling method with parameter Rajkot */
            userInformation.Print("Rajkot");

            /* Calling method with parameters 9408039142 and abhishek.hansaliya@oneadvanced.com */
            userInformation.Print(9408039142, "abhishek.hansaliya@oneadvanced.com");


            /* Assignment Question 3 */

            Console.WriteLine("-------------------- Assignment Question 3 --------------------\n");

            /* Creating object */
            VehicleDetails details;

            /* Calling abstract method of Company class */
            details = new Company();
            details.Details();

            /* Calling abstract method of Model class */
            details = new Model();
            details.Details();

            /* Calling abstract method of Color class */
            details = new Color();
            details.Details();


            /* Assignment Question 4 */

            Console.WriteLine("-------------------- Assignment Question 4 --------------------\n");

            /* Creating object */
            IFruit fruit;

            /* Calling interface method from Apple class */
            fruit = new Apple();
            fruit.Details();

            /* Calling interface method from Banana class */
            fruit = new Banana();
            fruit.Details();


            /* Assignment Question 5 */

            Console.WriteLine("-------------------- Assignment Question 5 --------------------\n");

            /* Creating object */
            Calculator calculator = new Calculator();

            /* Calling interface methods */
            calculator.Addition(6, 2);
            calculator.Subtraction(7, 3);
            calculator.Multiplication(2, 3);
            calculator.Division(8, 4);

            /* Displaying results */
            Console.WriteLine("Multiple Inheritance using Interfaces.");
            Console.WriteLine("Addition : " + calculator.resultOfAddition);
            Console.WriteLine("Subtraction : " + calculator.resultOfSubtraction);
            Console.WriteLine("Multiplication : " + calculator.resultOfMultiplication);
            Console.WriteLine("Division : " + calculator.resultOfDivision);


            /* Assignment Question 6 - Public Access Modifier */

            Console.WriteLine("-------------------- Assignment Question 6 - Public --------------------\n");

            /* Creating object */
            PublicEncapsulation publicEncapsulation = new PublicEncapsulation();

            /* Calling field */
            Console.WriteLine("Hello " + publicEncapsulation.company);

            /* Calling method */
            publicEncapsulation.Message("Abhishek Hansaliya");


            /* Assignment Question 6 - Protected Access Modifier */

            Console.WriteLine("-------------------- Assignment Question 6 - Protected --------------------\n");

            /* Creating object */
            Program testProtected = new Program();

            /* Calling field */
            Console.WriteLine("Hello " + testProtected.company);

            /* Calling method */
            testProtected.Message("Abhishek Hansaliya");


            /* Assignment Question 6 - Internal Access Modifier */

            Console.WriteLine("-------------------- Assignment Question 6 - Internal --------------------\n");

            /* Creating object */
            InternalEncapsulation testInternal = new InternalEncapsulation();

            /* Calling field */
            Console.WriteLine("Hello " + testInternal.company);

            /* Calling method */
            testInternal.Message("Abhishek Hansaliya");


            /* Assignment Question 6 - Protected Internal Access Modifier */

            Console.WriteLine("-------------------- Assignment Question 6 - Protected Internal --------------------\n");

            /* Creating object */
            ProtectedInternalEncapsulation testprotectedInternal = new ProtectedInternalEncapsulation();

            /* Calling field */
            Console.WriteLine("Hello " + testprotectedInternal.company);

            /* Calling method */
            testprotectedInternal.Message("Abhishek Hansaliya");


            /* Assignment Question 7 */

            Console.WriteLine("-------------------- Assignment Question 7 --------------------\n");

            /* Creating object */
            Vehicle vehicle = new Vehicle();

            /* Calling methods */
            vehicle.Ford();
            vehicle.Model();


            /* Assignment Question 8 */

            Console.WriteLine("-------------------- Assignment Question 8 --------------------\n");

            /* Creating object */
            CarColor carColor = new CarColor();

            /* Calling methods */
            carColor.Ford();
            carColor.Model();
            carColor.Color();


            /* Assignment Question 9 */

            Console.WriteLine("-------------------- Assignment Question 9 --------------------\n");

            /* Creating objects */
            ModelOne modelOne = new ModelOne();
            ModelTwo modelTwo = new ModelTwo();

            /* Calling methods */
            modelOne.Company();
            modelOne.ModelFirst();

            modelTwo.Company();
            modelTwo.ModelSecond();


            /* Assignment Question 10 */

            Console.WriteLine("-------------------- Assignment Question 10 --------------------\n");

            /* "_" is discard, its a placeholder for variables that are unused */
            _ = new Constructor();
            _ = new Parameterized("Parameterized Constructor");

        }
    }
}
