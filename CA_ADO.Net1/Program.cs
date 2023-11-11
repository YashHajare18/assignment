

using Microsoft.Extensions.Configuration;

namespace CA_ADO.Net1
{
    internal class Program
    {

        private static IConfiguration _iconfiguration;
        static void Main(string[] args)
        {
            GetAppSettingsFile();
            Printproduct();
            //Console.WriteLine(Directory.GetCurrentDirectory());
        }
        static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("Appsetting.json", optional: false, reloadOnChange: true);
            _iconfiguration = builder.Build();
        }
        static void Printproduct()
        {
            Productlayer obj = new Productlayer(_iconfiguration);
            obj.Products();

        }
       
    }
}