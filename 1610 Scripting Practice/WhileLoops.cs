using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1610_Scripting_Practice
{
    internal class WhileLoops
    {
        /* Loops Notes:
            In general,
            • 'while loops' are good when you know your stopping condition, but not when you know how many times you want a program to loop or if you have a specific collection to loop through.
            • 'do...while loops' are only necessary if you definitely want something to run once, but then stop if a condition is met.
            • 'for loops' are best if you want something to run a specific number of times, rather than given a certain condition.
            • 'foreach loops' are the best way to loop over an array, or any other collection.
        */

        /* Jump Statements:
            Break:
            - At any point within a loop block, you can end it by using the break keyword.
            Continue:
            - The continue keyword is used to bypass portions of code. It will ignore whatever comes after it in the loop and then will go back to the top and start the loop again.
            Return:
            - The return keyword is another way to exit a loop, specifically loops that are used within a method. When a return is used within such a loop, it breaks out of the loop and returns control to the point in the program where the method was called.
        */

       
        
        // I'm going to need a function in order to call these out, because my "main" function is located in variables.cs 
        public void myWhileLoops()
        {
            int emails = 20;
            while (emails > 0)
            {
                emails--;
                Console.WriteLine($"One email has been deleted. There are {emails} emails left.");
            }

            Console.WriteLine("INBOX ZERO ACHIEVED!");

            // This is an example of a do...while loop. I added a jump statement to make it so the alarm rings 3 times and stops even if the "button" hasn't been clicked. 

            bool buttonClick = true;
            int alarmRings = 0;

            do
            {
                Console.WriteLine("BLARRRRR");
                alarmRings++;
                if (alarmRings == 3)
                {
                    break;
                }

            } while (buttonClick);

        }
    }
}
