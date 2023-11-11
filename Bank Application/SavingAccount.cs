using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bank_Application
{
    internal class SavingAccount :Account
    {
        const double minbala = 1000;
         const double RateOfIntrest = 0.3;
        static double Intrest;
        public SavingAccount(String Name, Double Balance) : base(Name, Balance) { }

        public override void withdraw(double amt)
        {
            if (BALANCE - amt > minbala)
            {
                BALANCE = BALANCE - amt;
                Onwithdraw(amt, BALANCE, NAME);
            }
            else
                throw new Insufficient_Balance("If you do this transaction the balance is less than minimum balance ",NAME);
        }
        public static double Payintrest(Account ref1)
        {
            SavingAccount temp;
            if(ref1 is SavingAccount) 
            {
                temp = (SavingAccount)ref1;
                Intrest = temp.BALANCE * RateOfIntrest;
                temp.BALANCE += Intrest;
                temp.ShowBal();
            }
            
            return Intrest;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", NAME, ID, BALANCE);
        }
    }
}
