using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ADO.Net1
{
    internal class Productlayer
    {
        private string connectionString;
        public Productlayer(IConfiguration iconfiguration)
        {
            connectionString = iconfiguration.GetConnectionString("Default");
        }

        public void Products()
        {
            using(SqlConnection sql=new SqlConnection(connectionString)) 
            {
                try
                {
                    
                    SqlCommand cmd1 = new SqlCommand("Select * from Employee", sql);
                    sql.Open();
                    SqlDataReader rd = cmd1.ExecuteReader();

                    while (rd.Read()) { 
                        Console.WriteLine("{0} {1} {2}", rd["Id"], rd["Name"], rd["Salary"]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
