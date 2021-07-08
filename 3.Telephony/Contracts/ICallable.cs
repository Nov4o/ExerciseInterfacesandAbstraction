using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Telephony.Contracts
{
    public interface ICallable
    {     
        public void Call(string number);
    }
}
