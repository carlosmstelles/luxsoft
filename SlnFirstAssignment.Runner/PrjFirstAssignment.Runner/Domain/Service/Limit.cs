using System;

namespace PrjFirstAssignment.Runner.Domain.Service
{
    public class Limit
    {
        public static int GetLimit()
        {
            Console.WriteLine("This option calculates the sum of all natural numbers that are a multiple of 3 or 5 below a informed limit ");
            Console.WriteLine();
            Console.Write("Please enter a valid limit number bigger than 0 or type exit for the previous options: ");
            Console.WriteLine();

            var inputLimit = Console.ReadLine();
            int limit = 0;

            if (int.TryParse(inputLimit, out limit))

                while (limit < 1)
                {
                    Console.Write("The value entered is not valid. Please enter a valid limit number bigger than 0 or type exit for the previous options: ");

                    var result = Console.ReadLine();

                    if (result == "exit")
                    {
                        return -1;
                    }

                    if (!int.TryParse(result, out limit)) continue;

                    if (limit > 0)
                    {
                        break;
                    }
                }

            return limit;
        }
    }
}
