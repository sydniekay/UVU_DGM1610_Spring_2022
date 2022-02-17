using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1610_Scripting_Practice
{
    internal class Operators
    {
        /* different operators
         
            +	Addition	    Adds together two values	                x + y	
            -	Subtraction	    Subtracts one value from another	        x - y	
            *	Multiplication	Multiplies two values	                    x * y	
            /	Division	    Divides one value by another	            x / y	
            %	Modulus	        Returns the division remainder	            x % y	
            ++	Increment	    Increases the value of a variable by 1	    x++	
            --	Decrement	    Decreases the value of a variable by 1	    x--
        
        */


        // I'm going to need a function in order to call these out, because my "main" function is located in variables.cs 
        public void myOperators()
        {
            // operators in action without declared variables first
            double combo = (25.00 + 362.00) / 5.63;
            Console.WriteLine(combo);


            // variables
            int firstNumber = 25;
            int secondNumber = 360;
            int thirdNumber = 5;
            string firstWord = "Swimming";
            string secondWord = "Pool";

            // variables using operators
            double comboNumber = firstNumber + secondNumber / thirdNumber;
            string comboString = firstWord + " " + secondWord;

            Console.WriteLine(comboNumber.ToString());
            Console.WriteLine(comboString);

        }


    }
}
