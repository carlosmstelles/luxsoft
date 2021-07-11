using System.Linq;

namespace SequenceAnalysisLibrary.Domain.Service
{
    public class SequenceAnalysis
    {
        /// <summary>
        /// Using Linq I check for every letter of the text, identifying which one it's uppercase and order alphabetically
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
