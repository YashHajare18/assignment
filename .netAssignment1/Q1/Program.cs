/*Create class library with method fact() which will return factorial of a 
 * number. Use it in console application

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator c1 = new calculator();
            int a, b, c ,d;
            Console.WriteLine("enter two no to add");
           a = Convert.ToInt32(Console.ReadLine());
           b= Convert.ToInt32(Console.ReadLine());
            int aad=c1.Add(a, b);
            Console.WriteLine("the add of two no is="+aad);
            Console.WriteLine("enter two no to calculate product of that no");
            c= Convert.ToInt32(Console.ReadLine());
            d= Convert.ToInt32(Console.ReadLine());
            int pro=c1.product(c,d);
            Console.WriteLine("the product of two no is="+pro);
        }
    }
}
