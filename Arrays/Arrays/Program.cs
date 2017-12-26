using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
// adding directive console to reduce additional typing of console when using write line

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare two arrays, one of integers and one of characters
            int[] theNumbers = { 5, 10, 15, 20, 25 };
            char[] theLetters = { 'A', 'B', 'C', 'D', 'E' };

            /* each entry in an array are called elements and are assigned an element number to reference the spot
             * for example the number 5 in theNumbers is element 0 and the number 25 is element 4
             * as for theLetters 'A' is number 0 and E is number 4
             */
             
         // first example is to display both arrays using the foreach loop
         foreach(int i in theNumbers) //foreach loop listing each element in the array theNumbers
            {
                Write(i+" "); // + " "  is to add a space between the entries allowing easier readability

            }

            WriteLine("\nPress any key to display the next array");
            ReadKey(); // to hold the display open until a key is pressed

         foreach(char c in theLetters) //foreach loop listing each element in the array theLetters
            {
                Write(c + " "); 
            }
            WriteLine("\nPress any key to display the next array");
            ReadKey();

            //consider if we use a the for loop that requires parameters to start and stop, a different approach is needed
            
            WriteLine("\nLet's try a for loop instead of foreach");

            for (int j = 0; j < theNumbers.Length; j++) 
                /* we create an integer variable "j" and set the value to 0 and compare
                 * the variable j which equals zero to the array size by using theNumbers.Length
                 * the additional .Length tells the program that if 0 is less than 4 proceed with the loop
                 * j++ is code for positive iteration going up 1 number each loop sequence
                 */
            {
                Write(theNumbers[j]);
                Write(" "); // to add a space between numbers for easier readability
            }

            ReadKey();
          




        }
    }
}
