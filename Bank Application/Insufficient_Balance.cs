using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    internal class Insufficient_Balance :ApplicationException
    {
        String Massage; String Name;
        public Insufficient_Balance(String Massage,String Name) 
        {
            this.Massage = Massage;
            this.Name = Name;
        }
        public override string ToString()
        {
            return Massage+ ", Account holder="+Name ;
        }
    }
}
