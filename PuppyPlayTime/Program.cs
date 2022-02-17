using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppyPlayTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // My Variables
            string name = "Poppy";
            string breed = "Cavalier King Charles Spaniel";
            int age = 2;
            double weight = 13.5;
            bool beenFixed = true;

            // Printed to the console
            Console.WriteLine($"Hi! My name is {name}. I am a {age} year old {breed}. I weigh {weight} pounds, and thanks to my human it is {beenFixed} that I am spayed. Are you here to play with me?");

            // User input
            string answer = Console.ReadLine();
            if (answer.ToLower() == "yes")
            {
                Console.WriteLine("Yay! That makes me happy!");
            }
            else
            {
                Console.WriteLine("That's too bad, maybe come play another time!");
            }

            while (true);
        }
    }
}