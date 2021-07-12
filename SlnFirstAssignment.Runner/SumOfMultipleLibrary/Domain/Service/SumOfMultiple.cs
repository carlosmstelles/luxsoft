using System;

namespace SumOfMultipleLibrary.Domain.Service
{
    /// <summary>
    /// Class responsible to get the sum of multiples of 3 and 5 until the informed limit
    /// </summary>
    public class SumOfMultiple
    {
        /// <summary>
        /// Method responsabile to sum the result of the sum of multiples of 3 and 5 until the informed limit. Since 15 it's common to both of them,
        /// was necessary to sum the 15 multiples too, and remove from the final result otherwise it would return duplicate values.
        /// </summary>
        /// <param name="limit"></param>
        /// <returns></returns>
        public static double Resolve(long limit)
        {
            var sumOf3 = sumOfMultiples(3, limit);
            var sumOf5 = sumOfMultiples(5, limit);
            var sumOf15 = sumOfMultiples(15, limit);

            return sumOf3 + sumOf5 - sumOf15;
        }

        /// <summary>
        /// Methods responsabile to sum, the multiples of 3, 5 and 15 until the informed limit. The Math.Floor fucntion it's use to return the number of possible multiples of x
        /// If the result it's bigger than 0 the operation x * n * (n + 1) / 2 it's executed so it can get the sum of this multiples numbers
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double sumOfMultiples(int x, double y)
        {
            var n = Math.Floor((y - 1) / x);

            if (n > 0)
            {
                return x * n * (n + 1) / 2;
            }
            else return 0;
        }
    }
}
