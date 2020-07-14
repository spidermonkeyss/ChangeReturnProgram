using System;

namespace Utlity
{
    public class UserInput
    {
        public static int GetUserIntInput()
        {
            int intInput = 0;
            string input = "";

            bool isNumeric = false;
            while(isNumeric != true)
            {
                input = Console.ReadLine();
                bool isNumber = int.TryParse(input, out int n);
                if (!isNumber)
                {
                    Console.WriteLine("Not a number");
                    Console.WriteLine("Try again");
                    isNumeric = false;
                }
                else
                    isNumeric = true;
            }
            intInput = Convert.ToInt32(input);
            return intInput;
        }

        public static float GetUserFloatInput()
        {
            float floatInput = 0;
            string input = "";

            bool isNumeric = false;
            while (isNumeric != true)
            {
                input = Console.ReadLine();
                bool isNumber = float.TryParse(input, out float n);
                if (!isNumber)
                {
                    Console.WriteLine("Not a number");
                    Console.WriteLine("Try again");
                    isNumeric = false;
                }
                else
                    isNumeric = true;
            }
            floatInput = (float)Convert.ToDouble(input);
            return floatInput;
        }
    }
}