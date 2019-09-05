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
            bool isSarah = name.Equals("sarah"); // OR is name equal to "Sarah"?

                                                                              
            if (isJen)
            {
                Console.WriteLine("That's my name, too!" + " - with If/Else"); // Execute if isJen is TRUE ; then end code
            }

            else if (isSarah)
            {
                Console.WriteLine("That's my daughter's name!" + " - with If/Else"); // Execute if isJen is FALSE ; then end code
            }

            else
            {
                Console.WriteLine("Hi " + name + "!" + " -with If/Else"); // Execute if BOTH isJen AND isSarah are FALSE ; then end code
            }


            // Is name equal to Jen, Sarah or Other using switch/case

            switch (name)
            {
                case "jen":
                    Console.WriteLine("That's my name, too!" + " - with Switch/Case");
                    break;

                case "sarah":
                    Console.WriteLine("That's my daughter's name!" + " - with Switch/Case");
                    break;

                default:
                    Console.WriteLine("Hi " + name + "!" + " -with Switch/Case");
                    break;

            }








        }
    }
}
