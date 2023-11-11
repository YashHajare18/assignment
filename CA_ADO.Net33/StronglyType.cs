using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ADO.Net33
{
    internal class StronglyType
    {
        private string conectionstring;

        public StronglyType(IConfiguration configuration)
        {
            conectionstring = configuration.GetConnectionString("Default");
        }
        public SqlConnection GetSqlConnection()
        {
            SqlConnection sqlconn=new SqlConnection();
            sqlconn.ConnectionString = conectionstring;
            return sqlconn;
        }
        public List<Customer> GetList() { 
        var costomerList=new List<Customer>();
            try
            {
                using(SqlConnection conn = GetSqlConnection())
                {
                    SqlCommand cmd = new SqlCommand("dispCostomer", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader red = cmd.ExecuteReader();
                    if (red.HasRows)
                    {

                        while (red.Read()) 
                        {
                            costomerList.Add(new Customer
                            {
                                Id = Convert.ToInt32(red["Id"]),
                                Name = Convert.ToString(red["Name"]),
                                Address = Convert.ToString(red["Address"]),
                                Mobno = Convert.ToString(red["Mobno"]),


                            });
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {

            }
            return costomerList;
        }

        internal void delete(int i)
        {
            try
            {
                using(SqlConnection conn = GetSqlConnection())
                {
                    SqlCommand cmd = new SqlCommand("@Delete", conn);
                    cmd.CommandType= CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Pid",SqlDbType.Int).Value = i;
                    conn.Open();
                    Console.WriteLine("connected");
                    int no = cmd.ExecuteNonQuery();
                    Console.WriteLine("Row affected=" + no);
                    conn.Close();
                }
            }
            catch (Exception ex) { }

            
        }
        public void AddData(Customer e)
        {
            try
            {
                  using( SqlConnection conn = GetSqlConnection())
                {
                    SqlCommand cmd = new SqlCommand("@storedata", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Parameters.Add("@Name",SqlDbType.NVarChar).Value = e.Name;
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = e.Address;
                    cmd.Parameters.Add("@Mobno", SqlDbType.NVarChar).Value = e.Mobno;
                    conn.Open();
                    int no= cmd.ExecuteNonQuery();
                    Console.WriteLine("no of object of Custmore id added=" + no);
                    conn.Close();
                }
            }
            catch (Exception ex) { }
        }

        public void upDate(int id)
        {
            try
            {
                using(SqlConnection conn =GetSqlConnection())
                {
                    SqlCommand cmd = new SqlCommand("@UPDATE", conn);
                    cmd.CommandType=CommandType.StoredProcedure;


                }
            }
            catch (Exception ex) { }    
        }
    }
}
