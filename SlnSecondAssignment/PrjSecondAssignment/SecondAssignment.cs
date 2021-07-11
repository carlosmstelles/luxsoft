using System;

namespace PrjSecondAssignment
{
    public class SecondAssignment
    {
        static void Main(string[] args)
        {
            do
            {
                int x = 0;
                int y = 0;

                Console.WriteLine("Assignment 2\r");
                Console.WriteLine("Enter the value of X and Y to discover if it's possible to divide them with or without a remainder");
                Console.WriteLine();

                Console.WriteLine("Enter the value of X: ");
                Int32.TryParse(Console.ReadLine(), out x);
                Console.WriteLine();

                Console.WriteLine("Enter the value of Y: ");
                Int32.TryParse(Console.ReadLine(), out y);
                Console.WriteLine();

                int mod = CallMod(x, y);
                PrintMod(x, y, mod);

            }
            while (true);
        }

        private static void PrintMod(int x, int y, int mod)
        {
            Console.WriteLine();
            Console.WriteLine($"if 1 {x} can be divided by {y} without a remainder, If 0 {x} can't be divided by {y} without a remainder.  Result: {mod}");
            Console.WriteLine();
            Console.ReadKey();
        }

        /// <summary>
        /// Using bitwise operators so I can determinated if it's 1 or 0.
        /// I had to use cast on X and Y to avoid error when dividing by 0.
        /// First I test if Y it's 0, if yes return 0, 
        /// if not I test if the remainder it's 1 if yes, I invert the result (0 become 1),
        /// if not I test if the remainder it's 1 if yes, I invert the result (0 become 1). 
        /// I had to use >>31 so I could roll all bits of the integer.
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

        private static int CallMod(int x, int y)
        {
            SecondAssignment secondAssignment = new SecondAssignment();

            return secondAssignment.IsXDivisibleByY(x, y);
        }
    }
}
