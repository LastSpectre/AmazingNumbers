using System;
using System.Collections.Generic;

namespace AmazingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Contains all different methods the user can use
            Dictionary<int, Action> AmazingNumberActions = new Dictionary<int, Action>()
            {
                {1, AmazingNumberMethods.SingleNumberAmazingCheck },
                {2, AmazingNumberMethods.MultipleNumberAmazingCheck },
                {3, AmazingNumberMethods.MultipleNumberPercentageAmazingCheck }
            };

            // variables to keep running and save user input
            bool keepRunning = true;
            string input;
            int actionOutput;

            while (keepRunning)
            {
                // ask player for input
                Console.WriteLine("Please type in what you wanna do: ");

                // AmazingNumberMethods
                Console.WriteLine("Check if a single number is amazing: 1");
                Console.WriteLine("Check how many numbers til x are amazing: 2");
                Console.WriteLine("Check the percentage of amazing number til x: 3");

                // Quit the application
                Console.WriteLine("Quit: 4");

                // save input
                input = Console.ReadLine();
                Console.WriteLine("");

                // if invalid input, start again
                if (!Helper.CheckIfValidActionInput(input))
                {
                    continue;
                }
                // if valid input
                else
                {
                    // convert the to int
                    actionOutput = Convert.ToInt32(input);
                    
                    // does player want to quit?
                    if (actionOutput == 4)
                    {
                        keepRunning = false;
                    }
                    // perform amazing number action
                    else
                    {
                        AmazingNumberActions[actionOutput]();
                    }
                }
            }
        }
    }
}