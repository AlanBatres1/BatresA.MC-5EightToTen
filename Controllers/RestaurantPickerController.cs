using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatresA.MC_5EightToTen.Services;
using Microsoft.AspNetCore.Mvc;

namespace BatresA.MC_5EightToTen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerServices _restaurantPickerServices;
        public RestaurantPickerController(RestaurantPickerServices restaurantPickerServices)
        {
        _restaurantPickerServices = restaurantPickerServices;
        }

        [HttpGet]
        [Route("RestaurantPicker/{foodType}")]

        public string RestaurantPicker(string foodType)
        {
            return _restaurantPickerServices.RestaurantPicker(foodType);
        }
    }
}