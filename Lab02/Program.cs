using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Lab02 assignment!");
            GetUserInputs();
        }

        private static void GetUserInputs()
        {
            Console.WriteLine("Please enter in an integer between 1-100");
            int userInput = int.Parse(Console.ReadLine());

            BuildResponse(userInput);
        }

        private static void BuildResponse(int userInput)
        {
            Console.WriteLine(string.Format("{0}{1}", CheckIfInputIsOddOrEven(userInput), CheckNumberRange(userInput)));
            QuitConsoleApp(false);
        }

        private static string CheckNumberRange(int userInput)
        {
            string numberRangeResponse;

            if (Enumerable.Range(1, 25).Contains(userInput))
            {
                numberRangeResponse = string.Format("and in the range of 1-25");
            }
            else if(Enumerable.Range(26, 25).Contains(userInput))
            {
                numberRangeResponse = string.Format("and in the range of 26-50");
            }
            else if(Enumerable.Range(51, 25).Contains(userInput))
            {
                numberRangeResponse = string.Format("and in the range of 51-75");
            }
            else if(Enumerable.Range(76, 25).Contains(userInput))
            {
                numberRangeResponse = string.Format("and in the range of 76-100");
            }
            else
            {
                numberRangeResponse = "";
                Console.Clear();
                QuitConsoleApp(true);
            }
            return numberRangeResponse;
        }

        private static string CheckIfInputIsOddOrEven(int userInput)
        {
            string oddOrEven;

            if (userInput % 2 == 0)
            {
                oddOrEven = string.Format("Your input {0} is even ", userInput);
            }
            else
            {
                oddOrEven = string.Format("Your input {0} is odd ", userInput);
            }

            return oddOrEven;
        }

        private static void QuitConsoleApp(bool bit)
        {
            if (bit)
            {
                Console.WriteLine(string.Format("Your input was not within the 1-100 range."));
            }

            Console.WriteLine("\n\nPress R to repeat or any other key to exit the app.");
            ConsoleKeyInfo quitKey = Console.ReadKey();

            if (quitKey.Key.ToString().ToLower() == "r")
            {
                Console.Clear();
                GetUserInputs();
            }
            else
            {
                return;
            }
        }
    }
}
