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
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _guessItServices;

        public GuessItController(GuessItServices guessItServices){
            _guessItServices = guessItServices;
        }

        [HttpPost]
        [Route("ModeEasy/{easyNum}")]

        public string EasyGuess(string easyNum){
            return _guessItServices.EasyMode(easyNum);
        }

        [HttpPost]
        [Route("ModeMed/{medNum}")]

        public string MediumGuess(string medNum){
            return _guessItServices.MediumMode(medNum);
        }

        [HttpPost]
        [Route("ModeHard/{hardNum}")]

        public string HardGuess(string hardNum){
            return _guessItServices.HardMode(hardNum);
        }
    }
}