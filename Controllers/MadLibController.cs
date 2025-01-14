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
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;

        public MadLibController(MadLibServices madLibServices){
            _madLibServices = madLibServices;
        }

        [HttpPost]
        [Route("MadLibs/{name}/{place}/{adjective}/{animal}/{verb}/{color}/{noun}/{number}/{vehicle}/{profession}")]

        public string MadLibs(string name, string place, string adjective, string animal, string verb, string color, string noun, string number, string vehicle, string profession){
            return _madLibServices.TheMadLibs(name, place, adjective, animal, verb, color, noun, number, vehicle, profession);
        }
    }
}