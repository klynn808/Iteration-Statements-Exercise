using System.ComponentModel;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Net.NetworkInformation;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below

        //Call the methods to test them in the Main method below 

        //1) Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console all numbers 1000 through -1000.
        public static void PrintPositiveToNegative(int ceiling, int floor)
        {
            for (int i = ceiling; i >= floor; i--)
            {
                Console.WriteLine(i);
            }
        }

        //2) Write a method that will print to the console numbers 3 through 999 by 3 each time.

        public static void PrintFactorThree()
        {
            for (int i = 3; i >= 3 && i <= 999; i++)
            {
                    if (i % 3 == 0)
                        Console.WriteLine(i);
            }
        }

        //3) Write a method to accept two integers as parameters and check whether they are equal or not

        public static bool TwoEqualIntegers(int a, int b)
        {
                // simple ternary
            var isEqual = (a == b) ? true : false;

            Console.WriteLine(isEqual);

            return isEqual;
        }
        //4) Write a method to check whether a given number is even or odd 

        public static void isOddOrEven()
        {
            var aNumber = 1;
            if (aNumber == 0)
            {
                Console.WriteLine($"{aNumber} is 0.");
            }
            else if (aNumber % 2 == 0)
            {
                Console.WriteLine($"{aNumber} is even.");
            }
            else
            {
                Console.WriteLine($"{aNumber} is odd.");
            }
        }

        //5) Write a method to check whether a given number is positive or negative

        public static void PositiveOrNegative(int checkNumber)
        {
            if (checkNumber != 0)
            {
                var message = (checkNumber > 0) ? $"{checkNumber} is positive" : $"{checkNumber} is negative";
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine($"{checkNumber} is {checkNumber}");
            }
        }
        // 6) Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge 

        public static void CanVote()
        {
            Console.WriteLine("Tell me your age.");
            string? userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int voterAge))
            {
                var message = (voterAge >= 18) ? "You can vote!" : "You cannot vote yet.";
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Invalid age input. Please enter a valid age.");
            }
        }
        //Heatin Up Section:
        //1) Write a method to check if an integer(from the user) is in the range -10 to 10 

        public static void IsInRange()
        {
            Console.WriteLine("Give me a number between -10 and 10");
            string? userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int userNumber))
            {
                if (userNumber >= -10 && userNumber <= 10)
                {
                    Console.WriteLine($"Great job! {userNumber} is in between -10 and 10. You can follow directions.");
                }
                else
                {
                    Console.WriteLine($"{userNumber} is not in the correct range, try again later.");
                }
            }
            else if (TryConvertWordToNumber(userInput, out int wordNumber))
            {
                if (wordNumber >= -10 && wordNumber <= 10)
                {
                    Console.WriteLine($"Great job! {wordNumber} is in between -10 and 10. You can follow directions.");
                }
                else
                {
                    Console.WriteLine($"{wordNumber} is not in the correct range, try again later.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input. Please enter a valid number.");
            }
        }

        public static bool TryConvertWordToNumber(string? word, out int actualNumber)
        {
            if (word != null)
            {
                switch (word.ToLower())
                {
                    case "zero":
                        actualNumber = 0;
                        return true;
                    case "one":
                        actualNumber = 1;
                        return true;
                    case "two":
                        actualNumber = 2;
                        return true;
                    case "three":
                        actualNumber = 3;
                        return true;
                    case "four":
                        actualNumber = 4;
                        return true;
                    case "five":
                        actualNumber = 5;
                        return true;
                    case "six":
                        actualNumber = 6;
                        return true;
                    case "seven":
                        actualNumber = 7;
                        return true;
                    case "eight":
                        actualNumber = 8;
                        return true;
                    case "nine":
                        actualNumber = 9;
                        return true;
                    case "ten":
                        actualNumber = 10;
                        return true;
                    default:
                        actualNumber = int.MinValue;
                        return false;
                }
            }
            else
            {
                actualNumber = int.MinValue;
                return false;
            }
        }


        // 2) Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void DisplayMultiplicationTable(int baseNumber)
        {
            Console.WriteLine($"Multiplication table for {baseNumber}: ");

            for (int i = 1; i <= 12; i++)
            {
                int product = i * baseNumber;
                Console.WriteLine($"{baseNumber} * {i} = {product}");
            }

            //Console.WriteLine("Give me a number: ");

            //if (int.TryParse(Console.ReadLine(), out int baseNumber))
            //{
            //    DisplayMultiplicationTable(baseNumber);
            //}
            //else
            //{
            //    Console.WriteLine("The number you entered is not valid. Please input a number.");
            //}  
        }

        public static void Main(string[] args)
        {
            PrintPositiveToNegative(1000, -1000);
            PrintFactorThree();
            TwoEqualIntegers(3, 4);
            isOddOrEven();
            PositiveOrNegative(3);
            CanVote();
            IsInRange();

            string[] words = { "three", "seven", "zero", "tree", null };

            foreach (var word in words)
            {
                if (TryConvertWordToNumber(word, out int number))
                {
                    Console.WriteLine($"The word'{word}' converts to the number {number}.");
                }
                else
                {
                    Console.WriteLine($"The word '{word}' is not a valid number.");
                }
            }

            DisplayMultiplicationTable(4);


        }
    }
}





