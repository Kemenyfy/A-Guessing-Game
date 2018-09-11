using System;

namespace dotnet_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Think of a number between 1 and 100.");
            Console.WriteLine("I will be able to guess in 10 tries or less");
            Console.WriteLine("Ok? (Yes or No)");
            var answer = Console.ReadLine();
            if (answer == "No")
            {
                Console.WriteLine("I really wanted to play");
            } 
            else
            {
                Console.WriteLine("Ok, let's Play...");
            }
            Console.WriteLine("Is your number 50? (Yes - H for Higher - L for Lower)");
            var answer50 = Console.ReadLine();
            if (answer50 == "Yes")
            {
                Console.WriteLine("It took me 1 try!");
            }
            else if (answer50 == "H")
            {
                Console.WriteLine("Is your number 75? (Yes - H for Higher - L for Lower)");
            }
            else
            {
                Console.WriteLine("Is your number 25? (Yes - H for Higher - L for Lower)");
            }
        }
    }
}

