using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bank_Application
{
    internal class CurrentAccount :Account
    {
        public CurrentAccount(String Name,Double Balance):base(Name,Balance) { }

        public override void withdraw(double amt)
        {
            BALANCE = BALANCE - amt;
                Onwithdraw(amt, BALANCE, NAME);
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", NAME, ID, BALANCE);
        }
    }
}
