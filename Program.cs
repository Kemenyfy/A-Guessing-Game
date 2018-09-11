using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var min = 1;
            var max = 100;
            var Yes = "Yes";
            var Attempts = 0;
            var Higher = "H";
            var Lower = "L";
            var NumberToGuess = 50;

            Console.WriteLine($"Think of a number between {min} and {max}.");
            Console.WriteLine("I will be able to guess in 6 tries or less");
            Console.WriteLine("Ok? (Yes or No)");
            var answer = Console.ReadLine();
            if (answer == "No")
            {
                Console.WriteLine("I really wanted to play with you... Good bye.");
            }
            else
            {
                Console.WriteLine("Ok, let's Play...");
                do
                {
                    Console.WriteLine($"Is your number {NumberToGuess}? (Yes - H for Higher - L for Lower)");
                    var userAnswer = Console.ReadLine();
                    if (userAnswer.Equals($"{Yes}"))
                    {
                        Console.WriteLine($"It took me {Attempts} tries!");
                        break;
                    }
                    else if (userAnswer.Equals($"{Higher}"))
                    {
                        min = NumberToGuess + 1;
                        NumberToGuess = ((max - min) / 2) + min;
                        Attempts++;
                    }
                    else
                    {
                        if (userAnswer.Equals($"{Lower}"))
                        {
                            max = NumberToGuess - 1;
                            NumberToGuess = ((max - min) / 2 + min);
                            Attempts++;
                        }
                    }
                }
                while (Attempts <= 6);
            }
        }
    }
}
