using System;

namespace Day3PracticeActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks the user for their name and if it equals "Jen", returns "That's my name, too!"
            // Otherwise, return "Hi."

            Console.WriteLine("What's your name?"); // Ask user for their name

            string name = Console.ReadLine().ToLower(); // Allow user to enter name and store name in variable

            // Is name equal to "Jen"?

            bool isJen = name.Equals("jen");

            if (isJen)
            {
                Console.WriteLine("That's my name too!");
            }

            else
            {
                Console.WriteLine("Hi!");
            }
            

         




               
        }
    }
}
