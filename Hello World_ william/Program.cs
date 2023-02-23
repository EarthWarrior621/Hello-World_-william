// System namespce needed to use Console class.
using System;

// My collection of classes for this project.
namespace HelloWorld__William_Garcia
{
     // Main class for our program 
    class Program
    {
        // The Main method is executed when application starts
        static void Main(string[] args)
        {
             // Asks the user for first name
            Console.WriteLine("What is your first name?"); 
            // Assigns user input to firstName variable
            string firstName = Console.ReadLine(); 
            // Asks the user for last name
            Console.WriteLine("What is your last name?");
             // Assigns user input to lastName
            string lastName = Console.ReadLine();

            // Prints a welcome message with firstName and lastName
            Console.WriteLine($"Hello, " + firstName + " " + lastName + "!");
        }
    }
}
