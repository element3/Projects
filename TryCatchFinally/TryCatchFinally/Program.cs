using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
// directive console to save additional typing

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            // the try-catch-finally blocks are to eliminate errors, typically user error
            // a good example is when an Integer is requested from the user and they enter a Letter




            try // if a successful entry has been made
            {

                //prompt the user to enter a number via their age
                Write("Please enter your age in numeric form(example 0-120): ");
                int userInput = Convert.ToInt32(ReadLine()); // remember user input is a string until converted

                if (userInput > -1 && userInput < 121) // if else statement to allow the input to the try catch statement or deny
                {
                    WriteLine("You are {0} year(s) old", userInput);

                }
                else // if a number outside of 0-120 is entered
                {
                    WriteLine("Error: You entered a number outside of 0-120");
                }
            }

            catch (FormatException) // this message will show if anything other than a number(integer) is entered
            {
                WriteLine("Error: You did not entry a valid numeric entry");
            }
            finally // finally block will always display as long as the if statement is true
            {
                WriteLine("This statement will always run despite the previous try catch blocks");
                ReadKey(); // to hold the page open
            }
        }
                

          
            
                }


        }
    

