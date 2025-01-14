using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LazarB_Challenge_AllForOneAPI.Services
{
    public class AddNumbersServices
    {
        public string AddNumbers(string num1, string num2){
            int trueNum1;
            int trueNum2;
            if(int.TryParse(num1, out trueNum1) && int.TryParse(num2, out trueNum2)){
                return $"The sum of {trueNum1} and {trueNum2} is {trueNum1 + trueNum2}";
            }else{
                return "Invalid Data Type, both numbers inputted must be integers.";
            }
        }
    }
}