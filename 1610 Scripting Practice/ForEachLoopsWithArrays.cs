using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1610_Scripting_Practice
{
    internal class ForEachLoopsWithArrays
    {
        // In this exercise, we used For Each Loops to take each item from the given array and print them in a list. 
        public void myForEachLoops()
        {
            string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };

            foreach (string item in todo)
            {
                CreateTodoItem(item);
            }

        }

        static void CreateTodoItem(string item)
        {
            Console.WriteLine($"[] {item}");
        }
    }
}
