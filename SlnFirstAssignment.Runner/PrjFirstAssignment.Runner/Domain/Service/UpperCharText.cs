using System;
using System.Text.RegularExpressions;

namespace PrjFirstAssignment.Runner.Domain.Service
{
    /// <summary>
    /// Class responsible to get and treat the informed text.
    /// </summary>
    public class UpperCharText
    {
        /// <summary>
        /// Method responsible to return a valid text without special characters.
        /// </summary>
        /// <returns></returns>
        public static string GetUpperCharText()
        {
            Console.WriteLine("This option finds the uppercase characters in a text, and order it alphabetically. \n" +
                              "Please type your text, with at least one valid character and press enter: ");

            var result = RemoveSpecialChar(Console.ReadLine());

            while (string.IsNullOrEmpty(Regex.Replace(result, @"\s", "")))
            {
                Console.Write("The value entered it's not valid. Please type your text, with at least one valid character and press enter: \n");

                result = RemoveSpecialChar(Console.ReadLine());

                if (!string.IsNullOrEmpty(Regex.Replace(result, @"\s", "")))
                {
                    break;
                }
            }

            return result;
        }

        private static string RemoveSpecialChar(string text)
        {
            return Regex.Replace(text, "[^a-zA-Z]+", " ");
        }
    }
}
