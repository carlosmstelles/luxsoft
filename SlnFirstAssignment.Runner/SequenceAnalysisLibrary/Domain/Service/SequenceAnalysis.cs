using System.Linq;

namespace SequenceAnalysisLibrary.Domain.Service
{
    /// <summary>
    /// Class responsible to get the upper case letters of the typed text and sort alphabetically.
    /// </summary>
    public class SequenceAnalysis
    {
        /// <summary>
        /// Method responsabile to return all the capital letters in a text,  using Linq it's check for every letter of the text, identifying which one it's uppercase and order alphabetically.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string UpperString(string text)
        {
            string result = string.Concat(text.Where(x => char.IsUpper(x)).OrderBy(x => x));

            return result;
        }
    }
}
