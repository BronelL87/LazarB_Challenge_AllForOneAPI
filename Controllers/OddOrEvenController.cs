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
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenServices _oddOrEvenServices;

        public OddOrEvenController(OddOrEvenServices oddOrEvenServices){
            _oddOrEvenServices = oddOrEvenServices;
        }

        [HttpPost]
        [Route("OddEven/{inputNum}")]

        public string OddEven(string inputNum){
            return _oddOrEvenServices.OddOrEven(inputNum);
        }
    }
}