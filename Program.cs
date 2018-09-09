using System;

namespace Treehouse.PracticeSession
{
    class Program
    {
        public static void Main()
        {
            // TODO Declare a boolean variable named "keepGoing"
                      // and assign it a value of "true". Use this variable to 
            // know when to exit the while loop.
          bool keepGoing = true;

            // TODO Define a while loop.
            // Keep looping as long as the variable "keepGoing" has a value of "true".
          while (keepGoing){            
            // TODO Prompt the user with the text "Enter a number:" 
            Console.WriteLine("Enter a number: ");
            // and assign their value to an "entry" string variable.
            string entry = Console.ReadLine();
            
            // TODO If the user entered the text "quit"...
                if (entry == "quit"){
                  // TODO Exit the program.
                  keepGoing = false;
                }
                
// TODO Else the user didn't enter the text "quit"...
                    
                  else {
                    // TODO Parse the user's entry to an integer
                    
                  int number = int.Parse(entry);
                    // TODO Square the user's provided number 
                  int result = number * number;
                    // TODO Output the result.
                   Console.WriteLine(number + " squared is " + result);
                  }
                  }
           Console.WriteLine("Goodbye!"); // TODO Output the text "Goodbye!" after exiting the loop.
        }
    }
}
