using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1610_Scripting_Practice
{
    internal class Switches
    {
        /* This is an example of syntax for Switches
         * switch(expression) 
            {
              case x:
                // code block
                break;
              case y:
                // code block
                break;
              default:
                // code block
                break;
            }
        */

        public void mySwitches()
        {
            //First you want to establish a variable, and then call out the variable inside the switch parenthesis.

            int day = 2;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;



            }

            //Let's try something a little different.

            char letter;
            Console.WriteLine("Enter a letter in the english alphabet");
            letter = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(letter))
            {
                case 'a':
                    Console.WriteLine("This letter is a vowel.");
                    break;
                case 'e':
                    Console.WriteLine("This letter is a vowel.");
                    break;
                case 'i':
                    Console.WriteLine("This letter is a vowel.");
                    break;
                case 'o':
                    Console.WriteLine("This letter is a vowel.");
                    break;
                case 'u':
                    Console.WriteLine("This letter is a vowel.");
                    break;
                default:
                    Console.WriteLine("This letter is a consonant.");
                    break;
            }
            
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();


            //You could use switches to determine how much an item could sell for.

            string value = "turnip";

            switch (value)
            {
                case "lettuce":
                    Console.WriteLine("180 bells");
                    break;
                case "squash":
                    Console.WriteLine("200 bells");
                    break;
                case "turnip":
                    Console.WriteLine("250 bells");
                    break;

            }


        }
    }
}
