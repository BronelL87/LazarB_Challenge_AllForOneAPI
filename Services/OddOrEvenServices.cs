using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LazarB_Challenge_AllForOneAPI.Services
{
    public class OddOrEvenServices
    {
        public string OddOrEven(string inputNumber)
        {
            int absoluteNum;

            if (int.TryParse(inputNumber, out absoluteNum) && (absoluteNum % 2 == 0))
            {
                return $"{absoluteNum} os am Even number.";
            }
            else if (int.TryParse(inputNumber, out absoluteNum) && (absoluteNum % 2 != 0))
            {
                return $"{absoluteNum} is an Odd number.";
            }
            else
            {
                return "Invalid Data Type. Input needs to be an integer.";
            }
        }
    }
}
