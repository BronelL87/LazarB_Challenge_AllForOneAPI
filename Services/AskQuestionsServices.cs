using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LazarB_Challenge_AllForOneAPI.Services
{
    public class AskQuestionsServices
    {
        public string AskQuestions(string userName, string userTime){
            return $"Hello! Your name is {userName} and you woke up at {userTime}.";
        }
    }
}