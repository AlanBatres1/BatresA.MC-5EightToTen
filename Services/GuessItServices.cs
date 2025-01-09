using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatresA.MC_5EightToTen.Services
{
    public class GuessItServices
    {
        public string GuessIt(string difficulty)
        {
            int guess;
            int attempts;
            int correctNum;
            Random rng = new Random();

            switch (difficulty)
            {
                case "Easy":
                    correctNum = rng.Next(1, 11);
                    return "Guess a number 1-10";

                case "Medium":
                    correctNum = rng.Next(1, 51);
                    return "Guess a number 1-50";

                case "Hard":
                    correctNum = rng.Next(1, 101);
                    return "Guess a number 1-100";

                default:
                    return "Invalid input please type in exactly (Easy), (Medium), (Hard)";
            }

            Console.WriteLine("Try to guess the winning number!");
            while (isValid == true)
            {
                string guessString = Console.ReadLine();
                attempts++;
                bool isInteger = int.TryParse(guessString, out guess);
                while (isInteger == false)
                {
                    Console.WriteLine("Please Enter in an Integer");
                    guessString = Console.ReadLine();
                    attempts++;
                    isInteger = int.TryParse(guessString, out guess);
                }

                if (guess > correctNum)
                {
                    Console.WriteLine("Your guess was too high try again.");

                }
                if (guess < correctNum)
                {
                    Console.WriteLine("Your guess was too low try again.");

                }
                if (guess == correctNum)
                {
                    Console.WriteLine("You Won!");
                    Console.WriteLine($"It took {attempts} guesses.");
                }
            }
        }

    }
}