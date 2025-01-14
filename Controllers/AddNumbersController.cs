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
    public class AddNumbersController : ControllerBase
    {
        private readonly AddNumbersServices _addNumbersServices;

        public AddNumbersController(AddNumbersServices addNumbersServices){
            _addNumbersServices = addNumbersServices;
        }

        [HttpPost]
        [Route("AddTwoNums/{num1}/{num2}")]

        public string AddTwoNums(string num1, string num2){
            return _addNumbersServices.AddNumbers(num1, num2);
        }
    }
}