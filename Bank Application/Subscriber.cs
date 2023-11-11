using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    internal class Subscriber
    {
        public static void AddMethods()
        {
            Account.wdevent += Massage.Email;
            Account.wdevent += Massage.SMS;
        }
    }
}
