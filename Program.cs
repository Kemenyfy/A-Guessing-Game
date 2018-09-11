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

            Console.WriteLine($"Think of a number between {min} and {max}.");
            Console.WriteLine("I will be able to guess in 10 tries or less");
            Console.WriteLine("Ok? (Yes or No)");
            var answer = Console.ReadLine();
            if (answer == "No")
            {
                Console.WriteLine("I really wanted to play with you... Good bye.");
            } 
            else
            {
                Console.WriteLine("Ok, let's Play...");
            }
            Console.WriteLine("Is your number 50? (Yes - H for Higher - L for Lower)");
            var userAnswer = Console.ReadLine();
            if (userAnswer.Equals($"{Yes}"));
            {
                Console.WriteLine("It took me 1 try!");
            }
            if (Attempts >= 10)
            {
                Console.WriteLine("I've tried enough, I give up!");
            }
        }
    }
}
