using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Disconnected
{
    internal class EmpDAL
    {
        private string _configuration;

        public EmpDAL(IConfiguration configuration)
        {
            _configuration = configuration.GetConnectionString("Default");
        }
       
        public DataTable GetList()
        {
            DataAdapter 
        }
    }
}
