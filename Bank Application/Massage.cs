using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    internal class Massage
    {
        public static void Email(Double amt, Double bal, String Name)
        {
            Console.WriteLine("E-mail : Amount withdraw = {0} New Balance:{1} Name:{2}",amt,bal,Name);
        }
        public static void SMS(Double amt, Double bal, String Name)
        {
            Console.WriteLine("SMS : Amount withdraw = {0} New Balance:{1} Name:{2}", amt, bal, Name);
        }
    }
}
