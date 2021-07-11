using System;

namespace SumOfMultipleLibrary.Domain.Service
{
    public class SumOfMultiple
    {
        /// <summary>
        /// I sum the multiples of 3 and 5 until the informed limit, but since 15 it's common to both of them,
        /// I need to sum the 15 multiples too, and remove from the final result otherwise I'd get duplicate values.
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
        /// I use the function Math.Floor to return the number of possible multiples of x until the informed limit(y)
        /// If the result it's bigger than 0 I do the operation x * n * (n + 1) / 2 so I can get the sum of this multiples numbers
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
