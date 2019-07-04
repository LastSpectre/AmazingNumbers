using System;

namespace AmazingNumbers
{
    public static class AmazingNumberMethods
    {
        // prints out if x is an amazing number
        public static void SingleNumberAmazingCheck()
        {
            // players puts in a number
            Console.WriteLine("Please type in a number you want to check: ");
            string userInput = Console.ReadLine();
            
            // checks if input is valid, if not return
            if (!Helper.CheckIfValidNumber(userInput))
            {
                return;
            }
            // check if number is amazing or not
            else
            {
                // output is safe to convert now
                int numberOutput = Convert.ToInt32(userInput);

                if (!IsAmazing(numberOutput))
                {
                    Console.WriteLine("Number is not amazing.\n");
                    return;
                }
                else
                {
                    Console.WriteLine("Number is amazing!\n");
                    return;
                }
            }
        }

        // prints out how many number til x are amazing
        public static void MultipleNumberAmazingCheck()
        {
            // players puts in a number
            Console.WriteLine("Please type in the number up to which you want to check for amazing numbers: ");
            string userInput = Console.ReadLine();

            // checks if input is valid, if not return
            if (!Helper.CheckIfValidNumber(userInput))
            {
                return;
            }
            // valid input
            else
            {
                // safe to convert
                int numberOutput = Convert.ToInt32(userInput);

                // safe how many numbers are amazing
                int countForAmazingNumbers = 0;

                // print out how many numbers are amazing
                for (int i = 1; i <= numberOutput; i++)
                {
                    if (IsAmazing(i))
                    {
                        Console.WriteLine(i + " is amazing!");
                        countForAmazingNumbers++;
                    }
                }

                // if no numbers were amazing
                if(countForAmazingNumbers == 0)
                {
                    Console.WriteLine("No numbers were amazing.");
                }
            }

            Console.WriteLine("");
        }

        // checks how many numbers are percentage-wise amazing til x
        public static void MultipleNumberPercentageAmazingCheck()
        {
            // players puts in a number
            Console.WriteLine("Please type in the number up to which you want to check for amazing numbers (result is given in percent): ");
            string userInput = Console.ReadLine();

            // checks if input is valid, if not return
            if (!Helper.CheckIfValidNumber(userInput))
            {
                return;
            }
            // valid input
            else
            {
                // safe to convert
                int numberOutput = Convert.ToInt32(userInput);

                // count up amazing numbers
                int countForAmazingNumbers = 0;

                // iterates through all numbers up to x
                for (int i = 1; i <= numberOutput; i++)
                {
                    if (IsAmazing(i))
                    {
                        countForAmazingNumbers++;
                    }
                }

                // if no number was amazing
                if (countForAmazingNumbers == 0)
                {
                    Console.WriteLine("No numbers were amazing.");
                }
                // print out how much percent of numbers up to x were amazing
                else
                {
                    Console.WriteLine($"{((float)countForAmazingNumbers / (float)numberOutput) * 100}% of numbers up to {numberOutput} are amazing !");
                }
            }

            Console.WriteLine("");
        }

        // checks if the number (has exactly 3 divisors || is amazing)
        public static bool IsAmazing(int _number)
        {
            int divisors = 0;

            // tries to divide every i until _number with no rest
            for (int i = 1; i <= _number; i++)
            {
                // if division has no rest count up divisors
                if (_number % i == 0)
                {
                    divisors++;

                    // _number already has more than 3 dividers, return
                    if(divisors > 3)
                    {
                        return false;
                    }
                }
            }

            // _number has exactly 3 divisors
            if (divisors == 3)
            {
                return true;
            }
            // number has less than 3 dividers
            else
            {
                return false;
            }
        }
    }
}