using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public int facto(int x)
        {
            int fact = 1;
            for (int i = 1; i <= x; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
