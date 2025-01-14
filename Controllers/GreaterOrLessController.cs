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
    public class GreaterOrLessController : ControllerBase
    {
        private readonly GreaterOrLessServices _greaterOrLessThanServices;

        public GreaterOrLessController(GreaterOrLessServices greaterOrLessServices){
            _greaterOrLessThanServices = greaterOrLessServices;
        }

        [HttpPost]
        [Route("GreaterOrLessCheck/{number1}/{number2}")]

        public string GreaterOrLessCheck(string number1, string number2){
            return _greaterOrLessThanServices.GreaterThanOrLessThan(number1, number2);
        }
    }
}