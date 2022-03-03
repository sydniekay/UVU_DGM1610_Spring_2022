using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1610_Scripting_Practice
{
    internal class ForLoopsWithArrays
    {
        /* For Loop: 
         * There are always 3 statements in a for loop:
         * the first is your initialization statement, 
         * the second is a condition that tells the loop to keep going so long as it is true, 
         * and the third statement is typically an operation that allows you to change the state of the variable. 
         */

        /* Loops Notes:
         * In general,
         * • while loops are good when you know your stopping condition, but not when you know how many times you want a program to loop or if you have a specific collection to loop through.
         * • do...while loops are only necessary if you definitely want something to run once, but then stop if a condition is met.
         * • for loops are best if you want something to run a specific number of times, rather than given a certain condition.
         * • foreach loops are the best way to loop over an array, or any other collection.
         */

        // Here we are using a for loop to create a week template. 
        public void myForLoops()
        {
            for (int week = 1; week <= 16; week++)
            {
                CreateTemplate(week);
            }

        }

        static void CreateTemplate(int week)
        {
            Console.WriteLine($"Week {week}");
            Console.WriteLine("Announcements: \n \n \n ");
            Console.WriteLine("Report Backs: \n \n \n");
            Console.WriteLine("Discussion Items: \n \n \n");
        }
        
    }
}
