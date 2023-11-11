using Microsoft.Extensions.Configuration;
using System.Data;

namespace ADO_Disconnected
{
    internal class Program
    {
        private static IConfiguration configuration;

        static void Main(string[] args)
        {
            GetAppsettingsFile();
            PrintProduct();
        }

        public static void PrintProduct()
        {
           var empDAL = new EmpDAL(configuration);
            var dt = empDAL.GetList();
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                    Console.Write(row[col] + " ");
                Console.WriteLine("----------------------------------");
            }


        }

        public static void GetAppsettingsFile()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).
                                   AddJsonFile("Appsettings.json", optional: false, reloadOnChange: true);
            configuration = builder.Build();
        }

    }
}