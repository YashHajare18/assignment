using Microsoft.Extensions.Configuration;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

/*Q) : Create a table customer id name address mobno use table customer and complete following task
1: display all customer data(strongly type);
2: accept id from the user and delete particular customers;
3: create a object of customer and store data in customer table;
4: write search method with parameter id; write search method with parameter string(name, mobileno);
5: accept id and name from user and update the record
*/

namespace CA_ADO.Net33
{
    internal class Program
    {
        private static IConfiguration configuration;
        static void Main(string[] args)
        {
            GetAppSettingsFile();
            //  Console.WriteLine(Directory.GetCurrentDirectory());
            //PrintProduct();
            cosDisplay();

        }

        private static void cosDisplay()
        {
            StronglyType indata = new StronglyType(configuration);
            Console.WriteLine("display");
            List<Customer> last = indata.GetList();
            foreach (var l in last)
            {
                Console.WriteLine("{0}  {1}  {2}", l.Id, l.Name, l.Address, l.Mobno);
            }
            indata.delete(3);

            Console.WriteLine("After delete display");
            last = indata.GetList();

            foreach (var l in last)
            {
                Console.WriteLine("{0}  {1}  {2}", l.Id, l.Name, l.Address, l.Mobno);
            }
            Customer customer = new Customer{Name="Shushil",Address= "Yuganda", Mobno="9446748734"};
               indata.AddData(customer);
            Console.WriteLine("After add customer display");
            last = indata.GetList();

            foreach (var l in last)
            {
                Console.WriteLine("{0}  {1}  {2}", l.Id, l.Name, l.Address, l.Mobno);
            }
            indata.upDate(2);


        }
        
        private static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("Appsettings.json", optional: false, reloadOnChange: true);
            configuration= builder.Build();
            
        }
    }
}