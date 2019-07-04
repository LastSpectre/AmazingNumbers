using System;

namespace AmazingNumbers
{
    public static class Helper
    {
        // checks if the input is a valid action
        public static bool CheckIfValidActionInput(string _input)
        {
            if (!(int.TryParse(_input, out int _numberOutput)))
            {
                Console.WriteLine("Please type in a valid action.\n");
                return false;
            }

            if(_numberOutput <= 0 || _numberOutput > 4)
            {
                Console.WriteLine("Please type in an action between 1 and 4.\n");
                return false;
            }

            return true;
        }

        // Checks if the input is a number and greater than 0
        public static bool CheckIfValidNumber(string _input)
        {
            if (!(int.TryParse(_input, out int _numberOutput)))
            {
                Console.WriteLine("Please type in a valid number.\n");
                return false;
            }

            if(_numberOutput <= 0)
            {
                Console.WriteLine("Number has to be greater than 0.\n");
                return false;
            }

            return true;
        }
    }
}