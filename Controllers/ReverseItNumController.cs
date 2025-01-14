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
    public class ReverseItNumController : ControllerBase
    {
        private readonly ReverseItNumServices _reverseItNumServices;

        public ReverseItNumController(ReverseItNumServices reverseItNumServices){
            _reverseItNumServices = reverseItNumServices;
        }

        [HttpPost]
        [Route("ReverseNum/{userNums}")]

        public string ReverseNum(string userNums){
            return _reverseItNumServices.ReverseNums(userNums);
        }
    }
}