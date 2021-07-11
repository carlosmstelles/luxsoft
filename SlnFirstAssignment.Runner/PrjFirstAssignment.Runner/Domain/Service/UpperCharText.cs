using System;
using System.Text.RegularExpressions;

namespace PrjFirstAssignment.Runner.Domain.Service
{
    public class UpperCharText
    {
        public static string GetUpperCharText()
        {
            Console.WriteLine("This option finds the uppercase characters in a text, and order it alphabetically.");
            Console.Write("Please type your text, with at least one valid character and press enter: ");

            var result = RemoveSpecialChar(Console.ReadLine());

            while (string.IsNullOrEmpty(result))
            {
                Console.Write("The value entered it's not valid. Please type your text, with at least one valid character and press enter: ");

                result = RemoveSpecialChar(Console.ReadLine());

                if (!string.IsNullOrEmpty(result))
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
