using PrjFirstAssignment.Runner.Domain.Service;
using SequenceAnalysisLibrary.Domain.Service;
using SumOfMultipleLibrary.Domain.Service;
using System;

namespace PrjFirstAssignment.Runner
{

    class FirstAssignment
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Runner\n");

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

                        Console.WriteLine("Invalid option, please select a valid one. \n");
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
            Console.WriteLine($"\nThe sum of all numbers multiple of 3 and 5 below {limit} is: {result}\n");
        }
       
        private static void PrintSequenceAnalysis(string text, string result)
        {
            Console.WriteLine($"\nThe Uppercase characters alphabetically ordered of the text are: {result} from the text: {text}\n");
        }

        private static int DisplayAvailableProblemsMenu()
        {
            Console.WriteLine("Please select one of the options: \n" +
                               "1. SumOfMultiple\n" +
                               "2. SequenceAnalysis\n" +
                               "3. Exit\n");
            
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
