using PrjFirstAssignment.Runner.Domain.Service;
using SequenceAnalysisLibrary.Domain.Service;
using SumOfMultipleLibrary.Domain.Service;
using System;

namespace PrjFirstAssignment.Runner
{
    public class FirstAssignment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Runner");

            bool finish = false;

            while (!finish)
            {
                var selection = DisplayAvailableProblemsMenu();
                switch (selection)
                {
                    case 1:

                        var limit = Limit.GetLimit(); 

                        if (limit > 0)
                        {
                            var sumOfMultiple = CallSumOfMultiple(limit);
                            PrintSumOfMultiple(limit, sumOfMultiple);
                        }

                        break;
                    case 2:

                        var text = UpperCharText.GetUpperCharText();
                        var result = CallSequenceAnalysis(text);

                        PrintSequenceAnalysis(text, result);
                        break;
                    case 3:

                        finish = true;
                        break;
                    default:

                        Console.WriteLine("Invalid option, please select a valid one");
                        Console.WriteLine();
                        break;
                }
            }
        }


        private static double CallSumOfMultiple(int limit)
        {
            return SumOfMultiple.Resolve(limit);
        }

        private static string CallSequenceAnalysis(string text)
        {
            return SequenceAnalysis.UpperString(text);
        }

        private static void PrintSumOfMultiple(int limit, double result)
        {
            Console.WriteLine();
            Console.WriteLine($"The sum of all numbers multiple of 3 and 5 below {limit} is: {result}");
            Console.WriteLine();
        }
       
        private static void PrintSequenceAnalysis(string text, string result)
        {
            Console.WriteLine();
            Console.WriteLine($"The Uppercase characters alphabetically ordered of the text are: {result} from the text: {text}");
            Console.WriteLine();
        }

        public static int DisplayAvailableProblemsMenu()
        {
            Console.WriteLine("Please select one of the options: ");
            Console.WriteLine();
            Console.WriteLine("1. SumOfMultiple");
            Console.WriteLine("2. SequenceAnalysis");
            Console.WriteLine("3. Exit");
            Console.WriteLine();

            string option = Console.ReadLine()?.ToLower();

            switch (option)
            {
                case "1":
                    return 1;
                case "2":
                    return 2;
                case "3":
                    return 3;
            }

            if (int.TryParse(option, out var result))
            {
                return result;
            }

            return -1;
        }
      
    }
}
