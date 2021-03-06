using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _3.Telephony.Contracts;

namespace _3.Telephony.Models
{
    class StationaryPhone : ICallable
    {
        public void Call(string num)
        {
            if (!num.Any(x => char.IsDigit(x)) || (num.Length != 7 && num.Length != 10))
            {
                throw new InvalidOperationException("Invalid number!");
            }

            Console.WriteLine($"Dialing... {num}");
        }
    }
}
