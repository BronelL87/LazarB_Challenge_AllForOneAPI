using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LazarB_Challenge_AllForOneAPI.Services
{
    public class SayHelloServices
    {
        public string SayHello(string personName){
            return $"Hello, {personName}";
        }
    }
}