using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1610_Scripting_Practice
{
    internal class Conditionals
    {
        /*A condition is something that will output as "True" or "False".
         *A conditional is an expression that will evaluate to a condition. 
         *An "if statement" is an example of a conditional
         *
         *Let's start by making some variables to make a comparison with.
        */
        
        // I'm going to need a function in order to call these out, because my "main" function is located in variables.cs 
        public void myConditionals()
        {
            /*int numberOne = 10;
            int numberTwo = 25;

            if (numberOne < numberTwo)
            {
                return;
            }
            */
            

            //Let's try incorporating an "else" condition.
            Console.WriteLine("Welcome to Rent-A-Car! How old are you?");

            int userInfo = int.Parse(Console.ReadLine());


            if (userInfo < 25)
            {
                Console.WriteLine("Looks like you're too young to rent a vehicle.");
            }
            else
            {
                Console.WriteLine("Wonderful, you are eligible to rent a car from us.");
            }

           
        }



    }


}
