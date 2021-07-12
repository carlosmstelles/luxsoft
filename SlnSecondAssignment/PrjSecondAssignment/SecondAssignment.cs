using System;
using System.Text.RegularExpressions;

namespace PrjSecondAssignment
{
    /// <summary>
    /// Class responsabile to receive X and Y and call the method that will do the division. 
    /// </summary>
    public class SecondAssignment
    {
        static void Main(string[] args)
        {
            do
            {
                int x = 0;
                int y = 0;

                Console.WriteLine("Assignment 2\n" +
                                  "Enter the value of X and Y to discover if it's possible to divide them with or without a remainder\n");
              
                Console.WriteLine("Enter the value of X: ");
                x = GetNumber(Console.ReadLine());

                Console.WriteLine("\nEnter the value of Y: ");
                y = GetNumber(Console.ReadLine());

                int mod = CallMod(x, y);
                PrintMod(x, y, mod);

            }
            while (true);
        }

        private static void PrintMod(int x, int y, int mod)
        {
            Console.WriteLine($"\nif 1 {x} can be divided by {y} without a remainder, If 0 {x} can't be divided by {y} without a remainder.  Result: {mod}\n");
            Console.ReadKey();
        }

        /// <summary>
        /// Method responsible for divide X by Y
        /// Using bitwise operators to determinated if it's 1 or 0.
        /// Was necessary to use cast on X and Y to avoid error when dividing by 0.
        /// First it's tested if Y it's 0, if yes return 0, 
        /// if not it's tested if the remainder it's 1 if yes, than invert the result (0 become 1),
        /// if not it's tested if the remainder it's 1 if yes, than invert the result (0 become 1). 
        /// Was necessary to use >>31 to roll all bits of the integer.
        /// I was going to use this solution: 
        /// Convert.ToInt32((((double)X % (double)Y) >= 0) ^ (((double)X % (double)Y) > 0) ^ (((double)X % (double)Y) < 0))
        /// But I wasnt not sure if I could use Convert.
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        public int IsXDivisibleByY(int X, int Y)
        {
            int mod = (int)((double)X % (double)Y);
            return (((Y | (~Y + 1)) >> 31) & 1) & (~((1 + (~(mod) + 1)) >> 31) & 1) & (~(mod) & 1);
        }

        /// <summary>
        /// Method responsible to call the method that will divide X by Y.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int CallMod(int x, int y)
        {
            SecondAssignment secondAssignment = new SecondAssignment();

            return secondAssignment.IsXDivisibleByY(x, y);
        }

        private static string RemoveLetters(string text)
        {
            return Regex.Replace(text, "[^0-9]+", "");
        }

        private static int GetNumber(string n)
        {
            int result;
            var number = RemoveLetters(n);

            while (string.IsNullOrEmpty(number))
            {
                Console.Write("The value entered it's not valid. Please enter a number: \n");

                number = RemoveLetters(Console.ReadLine());

                if (!string.IsNullOrEmpty(number))
                {
                    break;
                }
            }

            Int32.TryParse(number, out result);

            return result;
        }
    }
}
