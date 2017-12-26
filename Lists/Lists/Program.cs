using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
// added directive system console to reduce typing for write line

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //while arrays hold a set number of entries, a List can add, replace, or reduce the entries

            //create a list
            List<int> userAges = new List<int> { 5, 10, 20 }; // 3 entries pre-declared 5,10,20

            // let's display the list so far
            WriteLine("Display the pre-declared List numbers: ");
            userAges.ForEach(WriteLine);

            ReadKey();

            // let's add to the List 15 and 25
            userAges.Add(15);
            userAges.Add(25);

            WriteLine("Let's display the added numbers 15 and 25");
            // then display the additional to the user
            WriteLine(" ");
            userAges.ForEach(WriteLine);
            ReadKey();

            // the additional can be put into a specific order with the insert command but first let's remove the additions

            //removal of 15 and 25
            userAges.Remove(15);
            userAges.Remove(25);

            WriteLine("\n Let's put the numbers in sequence by removing 15 and 25 then inserting them in the correct order\n ");

            userAges.Insert(2, 15);
            userAges.Insert(4, 25);

            //display the new results to the user
            userAges.ForEach(WriteLine);
            ReadKey();

            //finally let's remove the entire list
            userAges.Clear();

            WriteLine("\nNow let's remove everything in the list");
            userAges.ForEach(WriteLine);
            WriteLine("\nThe list is now empty");

       
            ReadKey();

            // let's do the same but with strings for a more practical approach in reference

            //create a list of names such as a the contact list in a phone
            List<string> userNames = new List<string> { "Bill", "Sally", "Jill" };

            // display the list to the user
            WriteLine("\nLet's display names this time!");
            userNames.ForEach(WriteLine);
            ReadKey();

            //put the names in alphabetical order
            userNames.Remove("Sally");
            userNames.Insert(2, "Sally");

            WriteLine("\nSally has been removed from the second position and inserted into the third\n");
            userNames.ForEach(WriteLine);
            WriteLine("Example of lists complete~ Ta Ta");
            ReadKey();

        }
    }
}
