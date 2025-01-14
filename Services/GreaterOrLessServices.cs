using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LazarB_Challenge_AllForOneAPI.Services
{
    public class GreaterOrLessServices
    {
        public string GreaterThanOrLessThan(string number1, string number2)
        {
            int real1;
            int real2;

            if (int.TryParse(number1, out real1) && int.TryParse(number2, out real2))
            {
                if (real1 > real2)
                {
                    return $"{real1} is greater than {real2}. {real2} is less than {real1}.";
                }
                else if (real1 < real2)
                {
                    return $"{real1} is less than {real2}. {real2} is greater than {real1}";
                }
                else
                {
                    return $"{real1} is equal to {real2}. {real2} is equal to {real1}";
                }
            }
            else
            {
                return "Invalid Data Type. Inputs must both be integers.";
            }
        }
    }
}