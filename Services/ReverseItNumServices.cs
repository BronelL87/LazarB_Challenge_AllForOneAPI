using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LazarB_Challenge_AllForOneAPI.Services
{
    public class ReverseItNumServices
    {
        public string ReverseNums(string userInt)
        {
            int trueInt;
            int reverseInt = 0;

            if (int.TryParse(userInt, out trueInt))
            {

                while (trueInt != 0)
                {
                    reverseInt = reverseInt * 10 + (trueInt % 10);
                    trueInt /= 10;
                }
                return $"Your numbers in reverse is: {reverseInt}";
            }
            else
            {
                return $"Invalid Data Type. Your numbers must be valid integers";
            }

        }
    }
}