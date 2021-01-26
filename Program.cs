/*
 Author: Mark Haxton
 Date: 1/25/2021
 Comments: week 3 assignment conditional statements
*/

using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("What numeric score do you expect to get in ISM 4300 (example 100)...");
            /*
               Use the try catch block to validate user input.
               If the user provides bad input, the catch block
               will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather the user input
                string input = Console.ReadLine();
                /* 
                   This variable will be used to store score
                   after the input variable is parsed to decimal
                 */
                decimal score  = decimal.Parse(input);

                // the following else if statements provide the letter grade

                if ((score >= 98) && (score <= 100))
                {
                    Console.WriteLine("A+");
                }
                else if ((score >= 92) && (score < 98))
                {
                    Console.WriteLine("A");
                }
                else if ((score >= 90) && (score < 92))
                {
                    Console.WriteLine("A-");
                }
                else if ((score >= 88) && (score < 90))
                {
                    Console.WriteLine("B+");
                }
                else if ((score >= 82) && (score < 88))
                {
                    Console.WriteLine("B");
                }
                else if ((score >= 80) && (score < 82))
                {
                    Console.WriteLine("B-");
                }
                else if ((score >= 78) && (score < 80))
                {
                    Console.WriteLine("C+");
                }
                else if ((score >= 72) && (score < 78))
                {
                    Console.WriteLine("C");
                }
                else if ((score >= 70) && (score < 72))
                {
                    Console.WriteLine("C-");
                }
                else if ((score >= 68) && (score < 70))
                {
                    Console.WriteLine("D+");
                }
                else if ((score >= 62) && (score < 68))
                {
                    Console.WriteLine("D");
                }
                else if ((score >= 60) && (score < 62))
                {
                    Console.WriteLine("D-");
                }
                else if (score < 60)
                {
                    Console.WriteLine("F");
                }
                
                // The following statement is to provide feedback if value is greater than 100%

                else // if (score > 100)
                {
                    Console.WriteLine("Number must not be more than 100");
                }
            } // end of try
            catch
            {
                Console.WriteLine("Please use a decimal data type for your score next time...");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            } // end of catch     
        } // end of Main
    } // end of class
} // end of namespace
