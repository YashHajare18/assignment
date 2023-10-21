using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the no to calculate its factorial");
            int a=Convert.ToInt32(Console.ReadLine());
            ClassLibrary1.Class1 c1 = new ClassLibrary1.Class1();
            int b = c1.facto(a);
            Console.WriteLine("factorial is"+b);
        }
    }
}
