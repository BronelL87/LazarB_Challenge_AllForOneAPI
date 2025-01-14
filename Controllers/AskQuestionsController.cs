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
    public class AskQuestionsController : ControllerBase
    {
        private readonly AskQuestionsServices _askQuestionsServices;

        public AskQuestionsController(AskQuestionsServices askQuestionsServices){
            _askQuestionsServices = askQuestionsServices;
        }

        [HttpPost]
        [Route("UserQuestions/{userName}/{userTime}")]

        public string UserQuestions(string userName, string userTime){
            return _askQuestionsServices.AskQuestions(userName, userTime);
        }
    }
}