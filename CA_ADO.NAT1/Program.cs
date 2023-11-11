/*Create a table employee with a column id name salary enter the 
 * record using sql connection class connect to the database and 
 * display record*/
using Microsoft.Extensions.Configuration;

namespace CA_ADO.Net1
{
    public class Program
    {
        private static IConfiguration _iconfiguration;
        static void Main(string[] args)
        {
            GetAppSettingsFile();
            PrintProduct();

        }

        private static void PrintProduct()
        {
            Productlayer obj = new Productlayer(_iconfiguration);
            obj.Products();
        }

        private static void  GetAppSettingsFile()
        {
            
            var builder = new ConfigurationBuilder().
                        SetBasePath(Directory.GetCurrentDirectory()).
                        AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _iconfiguration = builder.Build();
        }
    }
}