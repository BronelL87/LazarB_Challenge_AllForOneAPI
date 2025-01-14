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
    public class MagicBallController : ControllerBase
    {
        private readonly MagicBallServices _magicBallServices;

        public MagicBallController(MagicBallServices magicBallServices){
            _magicBallServices = magicBallServices;
        }

        [HttpPost]
        [Route("MagicBall/{userQuestion}")]

        public string MagicalBall(string userQuestion){
            return _magicBallServices.WiseBall(userQuestion);
        }
    }
}