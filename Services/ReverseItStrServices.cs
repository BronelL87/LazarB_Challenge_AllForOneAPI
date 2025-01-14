using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LazarB_Challenge_AllForOneAPI.Services
{
    public class ReverseItStrServices
    {
        public string ReverseString(string userStr){
            string reverseStr = "";

            for(int i = userStr.Length - 1; i >= 0; i--){
                reverseStr += userStr[i];
            }
            return $"Your string in reverse is: {reverseStr}";
        }
    }
}