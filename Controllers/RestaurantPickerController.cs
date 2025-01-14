using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LazarB_Challenge_AllForOneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace LazarB_Challenge_AllForOneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerServices _restaurantPickerServices;

        public RestaurantPickerController(RestaurantPickerServices restaurantPickerServices){
            _restaurantPickerServices = restaurantPickerServices;
        }

        [HttpPost]
        [Route("RestaurantPick/{FastFoodCasualFineDining}")]

        public string RandomRestaurant(string fastFoodCasualFineDining){
            return _restaurantPickerServices.PickRestaurant(fastFoodCasualFineDining);
        }
    }
}