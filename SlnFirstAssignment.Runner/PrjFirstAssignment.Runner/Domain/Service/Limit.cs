using System;

namespace PrjFirstAssignment.Runner.Domain.Service
{
    /// <summary>
    /// Class responsible to get and treat the informed limit.
    /// </summary>
    public class Limit
    {
        /// <summary>
        /// Method responsible to return a valid value bigger than 0
        /// </summary>
        /// <returns></returns>
        public static int GetLimit()
        {
            Console.WriteLine("This option calculates the sum of all natural numbers that are a multiple of 3 or 5 below a informed limit\n" +
                               "Please enter a valid limit number bigger than 0 or type exit for the previous options: \n ") ;

            var limit = int.MinValue;

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
