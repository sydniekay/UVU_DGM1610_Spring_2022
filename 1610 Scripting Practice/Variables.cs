using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1610_Scripting_Practice
{
    internal class Variables
    {
        static void Main(string[] args)
        {
            Operators operatorDemo = new Operators();
            operatorDemo.myOperators();

            Conditionals conditionalsDemo = new Conditionals();
            conditionalsDemo.myConditionals();

            // a list of variables with examples
            int myInt = 12;
            double myDecimal = 12.25;
            char myCharacter = 'H';
            string myString = "Happy";
            bool myBool = true;


            // using variables
            Console.WriteLine($"{myInt}+{myDecimal} is {myInt + myDecimal}.");
            Console.WriteLine($"{myString} starts with {myCharacter}.");
            Console.WriteLine($"Are you feeling {myString} today?");
            string response = Console.ReadLine();
            
            if (response.ToLower() == "yes")
            {
                Console.WriteLine("I'm glad to hear that!");
            }
            else
            {
                Console.WriteLine("I'm sorry to hear that.");
            }

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();


        }
    }
}
