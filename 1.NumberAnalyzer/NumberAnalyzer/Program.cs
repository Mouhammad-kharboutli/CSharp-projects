using System;
using System.Net.Mime;

namespace NumberAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            ShowStartupMessage();
            var userinputs = new List<decimal>();
            
            while (true)
            {

                Console.WriteLine("please enter a number");
                string userInput = Console.ReadLine();


                if (userInput.ToLower() == "analyze")
                {
                    AnalyzNumbers(userinputs);
                    userinputs.Clear();
                    continue;
                }

                if (userInput.ToLower() == "quit")
                {
                    Console.WriteLine("program Ended");
                    break;
                }

                if (decimal.TryParse(userInput, out decimal number))
                {
                    userinputs.Add(number);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }

        private static void AnalyzNumbers(List<decimal> numbers)
        {
            if (numbers.Count > 0)
            {
                var min = numbers.Min();
                var max = numbers.Max();
                var average = numbers.Average();

                Console.WriteLine($"\n" +
                                  $"numbers entered are [{string.Join(", ", numbers)}]");
                Console.WriteLine($"The min number is {min}");
                Console.WriteLine($"The max number is {max}");
                Console.WriteLine($"The average number is {average}");   
            }
            else
            {
                Console.WriteLine("No numbers has been entered to analyze");
            }
            
        }

        private static void ShowStartupMessage()
        {
            Console.WriteLine("Welcome to the Number Analyzer!");
            Console.WriteLine("Please enter 'quit' to end the program");
            Console.WriteLine("Please enter 'analyze' to analyze all numbers and show the result");
            Console.WriteLine("please enter numbers to analyze one by one");
            Console.WriteLine("------------------------------------");
        }
    }
}