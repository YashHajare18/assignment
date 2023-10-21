/*Create a class student in namespace DAC and in namespace DBDA write method 
 * add in both class. In entry point call both method
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dac.Student s1 = new Dac.Student();
            Dbda.Student s2 = new Dbda.Student();

            s1.add("Yash Hajare");
            s2.add("Shubham Gaikawad");
            Console.ReadLine();
        }
    }
}
