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
    public class ReverseItStrController : ControllerBase
    {
        private readonly ReverseItStrServices _reverseItStrServices;

        public ReverseItStrController(ReverseItStrServices reverseItStrServices){
            _reverseItStrServices = reverseItStrServices;
        }

        [HttpPost]
        [Route("ReverseStr/{userStr}")]

        public string ReverseStr(string userStr){
            return _reverseItStrServices.ReverseString(userStr);
        }
    }
}