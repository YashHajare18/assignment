using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HR_ADO.net
{
    internal class StronglyType
    {
        private string _configuration;
        public StronglyType(IConfiguration configuration) { 
           _configuration = configuration.GetConnectionString("Default");
        }
        public SqlConnection GetSqlConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = _configuration;
            return connection;
        }

        public List<Employee> GetList()
        {
            var Employeelist = new List<Employee>();
            try
            {
                using (SqlConnection conn = GetSqlConnection())
                {
                    SqlCommand cmd = new SqlCommand("@Display", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    Console.WriteLine("Connected");
                    SqlDataReader red = cmd.ExecuteReader();
                    if(red.HasRows)
                    {
                       while (red.Read())
                        {
                            Employeelist.Add(new Employee()
                            {
                                Id = Convert.ToInt32(red["Id"]),
                                Name = Convert.ToString(red["Name"]),
                                Salary = Convert.ToString(red["Salary"]),
                                Gender = Convert.ToString(red["Gender"]),
                                Address = Convert.ToString(red["Address"])
                            }) ;
                        }
                    }

                }
            }
            catch (Exception ex) { }
            
            return Employeelist;
        }

        internal void Insert(Employee emp)
        {
            try
            {
                using(SqlConnection conn =GetSqlConnection())
                {
                    SqlCommand cmd = new SqlCommand("@INSERT", conn);
                    cmd.CommandType= CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Id",SqlDbType.Int).Value=emp.Id;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = emp.Name;
                    cmd.Parameters.Add("@Salary", SqlDbType.NVarChar).Value = emp.Salary;
                    cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = emp.Gender;
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = emp.Address;
                    conn.Open();
                    Console.WriteLine("Connected");
                    int no=cmd.ExecuteNonQuery();
                    Console.WriteLine("no of row Added" + no);
                    conn.Close();
                }
            }
            catch { }
        }

        internal void Updte(Employee e, int id)
        {
            try
            {
                using (SqlConnection conn = GetSqlConnection())
                {
                    SqlCommand cmd = new SqlCommand("@UPDATE", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = e.Id;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = e.Name;
                    cmd.Parameters.Add("@Salary", SqlDbType.NVarChar).Value = e.Salary;
                    cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = e.Gender;
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = e.Address;
                    //cmd.Parameters.Add("@PCID", SqlDbType.Int).Value = id;
                    conn.Open();
                    Console.WriteLine("Connected");
                    int no = cmd.ExecuteNonQuery();
                    Console.WriteLine("no of row updated" + no);
                    conn.Close();
                }
            }
            catch { }

        }

        internal void Delete(int v)
        {
            try 
            { 

              using(SqlConnection conn = GetSqlConnection())
                {
                    SqlCommand cmd = new SqlCommand("@Delete", conn);
                    cmd.CommandType= CommandType.StoredProcedure;
                    cmd.Parameters.Add("@pId", SqlDbType.Int).Value = v;
                    conn.Open();
                    Console.WriteLine("Connected");
                    int no = cmd.ExecuteNonQuery();
                    Console.WriteLine("no of row Added" + no);
                    conn.Close();
                }
            } 
            catch { }
        }

        internal Employee Search(int v)
        {
            Employee p  = new Employee(); 
            try
            {
                using (SqlConnection conn = GetSqlConnection())
                {
                    SqlCommand cmd = new SqlCommand("Select * from Employee where Id=@Id", conn);
                    
                    cmd.Parameters.AddWithValue("@Id", v);
                    conn.Open();
                    Console.WriteLine("Connected for one emp");
                    SqlDataReader red = cmd.ExecuteReader();
                    if (red.HasRows)
                    {
                        while (red.Read())
                        {
                            
                            p.Id = Convert.ToInt32(red["Id"]);
                            p.Name = Convert.ToString(red["Name"]);
                            p.Salary = Convert.ToString(red["Salary"]);
                            p.Gender = Convert.ToString(red["Gender"]);
                            p.Address = Convert.ToString(red["Address"]);

                            break;
                        }
                    }

                }
            }
            catch { }
            return p;

        }
    }
}
