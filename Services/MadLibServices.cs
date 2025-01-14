using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LazarB_Challenge_AllForOneAPI.Services
{
    public class MadLibServices
    {
        public string TheMadLibs(string userName, string userPlace, string userAdjective, string userAnimal, string userVerb, string userColor, string userNoun, string userNumber, string userVehicle, string userProfession)
        {

            int trueNum;

            if (int.TryParse(userNumber, out trueNum))
            {
                return $"One day, {userName} was walking through {userPlace} when they saw a {userAdjective} {userAnimal}. They decided to {userVerb} with the {userAnimal}, but then a {userColor} {userNoun} appeared randomly. 'Bro...What??' {userName} exclaimed, as {trueNum} {userVehicle}s drove by. As it turns out the {userNoun} was trying to become a {userProfession}. What a strange day in {userPlace}.";
            }
            else
            {
                return "Invalid Data Type, userNumber needs to be a integer";
            }

        }
    }
}