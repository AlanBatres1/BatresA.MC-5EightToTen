using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatresA.MC_5EightToTen.Services
{
    public class RestaurantPickerServices
    {
        public string RestaurantPicker(string foodType)
        {
            Random rng = new Random();
            string option = "";

            if (foodType != "Fast Food" && foodType != "Mexican" && foodType != "Chinese")
            {
                return "Please enter the correct category (Fast Food) (Mexican) (Chinese)";
            }

            if (foodType == "Fast Food")
            {
                switch (rng.Next(11))
                {
                    case 1:
                        option = "McDonald's";
                        break;
                    case 2:
                        option = "Wendy's";
                        break;
                    case 3:
                        option = "Burger King";
                        break;
                    case 4:
                        option = "Taco Bell";
                        break;
                    case 5:
                        option = "Jack in the Box";
                        break;
                    case 6:
                        option = "In-N-Out Burger";
                        break;
                    case 7:
                        option = "Raising Canes";
                        break;
                    case 8:
                        option = "Chick-fil-A";
                        break;
                    case 9:
                        option = "KFC";
                        break;
                    case 10:
                        option = "Subway";
                        break;
                }
            }
            else if (foodType == "Mexican")
            {
                switch (rng.Next(11))
                {
                    case 1:
                        option = "Tacos Chapala";
                        break;
                    case 2:
                        option = "Tepa Taqueria";
                        break;
                    case 3:
                        option = "El Grullito";
                        break;
                    case 4:
                        option = "El Torito";
                        break;
                    case 5:
                        option = "Arroyo's Cafe";
                        break;
                    case 6:
                        option = "El Mayita";
                        break;
                    case 7:
                        option = "Birrialandia";
                        break;
                    case 8:
                        option = "Gallo's Taco Truck";
                        break;
                    case 9:
                        option = "Carolina's Grill Taqueria";
                        break;
                    case 10:
                        option = "Tequileros Taqueria";
                        break;
                }
            }
            else if (foodType == "Chinese")
            {
                switch (rng.Next(11))
                {
                    case 1:
                        option = "China Village Restaurant";
                        break;
                    case 2:
                        option = "Far East Restaurant";
                        break;
                    case 3:
                        option = "China Express";
                        break;
                    case 4:
                        option = "Panda Express";
                        break;
                    case 5:
                        option = "Louie's Chinese Restaurant";
                        break;
                    case 6:
                        option = "The Chopstick";
                        break;
                    case 7:
                        option = "New Yen Ching Restaurant";
                        break;
                    case 8:
                        option = "Sherman's 2 Chinese Buffet";
                        break;
                    case 9:
                        option = "New Shanghai Restaurant";
                        break;
                    case 10:
                        option = "M kitchen Buffet";
                        break;
                }
            }
            return option;
        }
    }
}
