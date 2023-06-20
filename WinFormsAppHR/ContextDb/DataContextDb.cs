using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppHR.Entities;

namespace WinFormsAppHR.ContextDb
{
    
    public class DataContextDb
    {
        private string _conn = null;        
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataReader _reader;

        public DataContextDb() {
            _conn = _connectionString();
            _connection = new SqlConnection(_conn); 
        }

        //getall
        public IEnumerable<Employee> GetAllEmployees()
        {
            string sql = "select * from Employees";
            IList<Employee> employees = new List<Employee>(); 
            try
            {
                //1. khoi tao conn
                _connection.Open();
                _command = new SqlCommand(sql, _connection); 
                _reader = _command.ExecuteReader(CommandBehavior.CloseConnection);
                if(_reader != null && _reader.HasRows) {
                    while(_reader.Read())
                    {
                        Employee e = new Employee();
                        e.EmpId = _reader.GetInt32("EmpId");
                        e.FullName = _reader.GetString("FullName");
                        e.Dob = _reader.GetDateTime("Dob");
                        e.WorkingDay = _reader.GetInt32("WorkingDay");
                        e.RateSalary = (float)_reader.GetDouble("SalaryRate");

                        employees.Add(e);


                    }
                
                }
                return employees;
            }
            catch ( Exception ex)
            {
                return null;

            }
            return null;

        }




        private string _connectionString()
        {
            string conn = null;
            try
            {
                IConfiguration config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", true, true)
               .Build();

                conn = config["ConnectionStrings:HRManagementDB"];
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
            return conn;
           
        }
    }
}
