using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatresA.MC_5EightToTen.Services
{
    public class GuessItServices
    {
            Random rng = new Random();
        public string GuessItEasy(string guess)
        {
            int easy = rng.Next(1, 11);
            bool isValid = int.TryParse(guess, out int num);
            if (isValid == false)
            {
                return "Integers only";
            }

                if (num > easy)
                {
                    return "Your guess was too high try again.";

                }
                else if (num < easy)
                {
                    return "Your guess was too low try again.";

                }
                else if (num == easy)
                {
                    return "You Won!";
                }
                return"";
        }

        public string GuessItMedium(string guess)
        {
            int easy = rng.Next(1, 51);
            bool isValid = int.TryParse(guess, out int num);
            if (isValid == false)
            {
                return "Integers only";
            }

                if (num > easy)
                {
                    return "Your guess was too high try again.";

                }
                else if (num < easy)
                {
                    return "Your guess was too low try again.";

                }
                else if (num == easy)
                {
                    return "You Won!";
                }
                return"";
        }

        public string GuessItHard(string guess)
        {
            int easy = rng.Next(1, 101);
            bool isValid = int.TryParse(guess, out int num);
            if (isValid == false)
            {
                return "Integers only";
            }

                if (num > easy)
                {
                    return "Your guess was too high try again.";

                }
                else if (num < easy)
                {
                    return "Your guess was too low try again.";

                }
                else if (num == easy)
                {
                    return "You Won!";
                }
                return"";
        }

    }
}