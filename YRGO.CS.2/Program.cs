using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YRGO.CS._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //One();
            //Two();
            //Three();
            //Four();
            //Five();
            //FiveBetterAI();
        }

        static void One()
        {
            var x = ReadNumber("Input a integer: ");
            var y = ReadNumber("Input another integer: ");

            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        }

        static void Two()
        {
            var firstYear = 0;
            var secondYear = 0;

            Console.WriteLine("LeapYearCalculator 2k15 v1.0");

            while (true)
            {
                Console.WriteLine();
                firstYear = ReadNumber("First year: ");

                if (firstYear > 0 && firstYear < 9999)
                {
                    Console.WriteLine("OK");
                    break;
                }

                Console.WriteLine("Year must be between 0 and 9999.");
            }

            while (true)
            {
                Console.WriteLine();
                secondYear = ReadNumber("Second year: ");

                if (secondYear > firstYear && secondYear < 9999)
                {
                    Console.WriteLine("OK");
                    break;
                }

                Console.WriteLine("Year must be between {0} and 9999.", firstYear);
            }

            Console.WriteLine();            
            Console.WriteLine("-------------------------------");
            for (int i = firstYear; i <= secondYear; i++)
            {
                Console.WriteLine("{0} {1}", DateTime.IsLeapYear(i) ? "*" : " ", i);
            }

        }

        static void Three()
        {
            var generator = new Random();
            var number = generator.Next(1, 11);

            Console.WriteLine("Guess a number between 1 and 10.");
            var guess = 0;
            do
            {
                guess = ReadNumber("> ");

                if (guess < number)
                    Console.WriteLine("Too small! :(");
                else if(guess > number)
                    Console.WriteLine("Too big! :(");

            } while (guess != number);

            Console.WriteLine("You are correct!");
        }

        static void Four()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }

        static void Five()
        {
            var generator = new Random();
            var number = generator.Next(1, 101);

            Console.WriteLine("Guess a number between 1 and 100.");
            var guess = 0;
            var computerLessThan = 100;
            var computerMoreThan = 1;
            var humanTurn = false;

            do
            {
                Console.WriteLine();
                humanTurn = !humanTurn;

                if(humanTurn)
                {
                    Console.Write("Humanitys last hope ");
                    guess = ReadNumber("> ");
                }
                else
                {
                    Console.Write("Skynet              ");
                    guess = generator.Next(computerMoreThan, computerLessThan + 1);
                    Console.Write("> {0}\n", guess);
                }

                if (guess < number)
                {
                    Console.WriteLine("Too small! :(");
                    if (computerMoreThan < guess)
                        computerMoreThan = guess;
                }
                else if (guess > number)
                {
                    Console.WriteLine("Too big! :(");
                    if (computerLessThan > guess)
                        computerLessThan = guess;
                }

            } while (guess != number);

            if (humanTurn)
                Console.WriteLine("You are correct! The world is free of Skynets rule! Or is it?...");
            else
                Console.WriteLine("Oh noes, Skynet wins!");
        }

        static void FiveBetterAI()
        {
            var generator = new Random();
            var number = generator.Next(1, 101);

            Console.WriteLine("Guess a number between 1 and 100.");
            var guess = 0;
            var computerLessThan = 100;
            var computerMoreThan = 1;
            var humanTurn = false;

            do
            {
                Console.WriteLine();
                humanTurn = !humanTurn;

                if (humanTurn)
                {
                    Console.Write("Humanitys last hope ");
                    guess = ReadNumber("> ");
                }
                else
                {
                    Console.Write("Skynet              ");
                    var computerGuess = ((computerLessThan - computerMoreThan) / 2) + computerMoreThan;
                    guess = computerGuess; // <= computerMoreThan ? computerMoreThan + 1 : computerGuess;
                    //guess = generator.Next(computerMoreThan, computerLessThan);
                    Console.Write("> {0}\n", guess);
                }

                if (guess < number)
                {
                    Console.WriteLine("Too small! :(");
                    if (computerMoreThan < guess)
                        computerMoreThan = guess;
                }
                else if (guess > number)
                {
                    Console.WriteLine("Too big! :(");
                    if (computerLessThan > guess)
                        computerLessThan = guess;
                }

            } while (guess != number);

            if (humanTurn)
                Console.WriteLine("You are correct! The world is free of Skynets rule! Or is it?...");
            else
                Console.WriteLine("Oh noes, Skynet wins!");
        }
        static int ReadNumber(string prompt)
        {
            var value = 0;
            while (true)
            {
                Console.Write(prompt);
                var input = Console.ReadLine();

                if (Int32.TryParse(input, out value))
                    return value;

                Console.WriteLine("Not a valid integer.");
            }
        }

    }
}
