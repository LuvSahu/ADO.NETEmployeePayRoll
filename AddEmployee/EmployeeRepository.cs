using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    public class EmployeeRepository
    {
        public static string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=payroll_service;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection = null;
    
        public void GetAllEmployees()
        {
            try
            {
                using (connection = new SqlConnection(ConnectionString))
                {
                    EmployeePayroll model = new EmployeePayroll();
                    string query = "select * from employee_payroll";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            model.Id = Convert.ToInt32(reader["Id"] == DBNull.Value ? default : reader["Id"]);
                            model.Name = reader["Name"] == DBNull.Value ? default : reader["Name"].ToString();
                            model.Salary = Convert.ToDouble(reader["Salary"] == DBNull.Value ? default : reader["Salary"]);
                            model.StartDate = (DateTime)((reader["StartDate"] == DBNull.Value ? default : reader["StartDate"]));
                            model.Gender = Convert.ToChar(reader["Gender"] == DBNull.Value ? default : reader["Gender"]);
                            model.PhoneNumber = Convert.ToInt64(reader["PhoneNumber"] == DBNull.Value ? default : reader["PhoneNumber"]);
                            model.Department = reader["Department"] == DBNull.Value ? default : reader["Department"].ToString();
                            model.Address = reader["Address"] == DBNull.Value ? default : reader["Address"].ToString();
                            model.BasicSalary = Convert.ToDouble(reader["BasicSalary"] == DBNull.Value ? default : reader["BasicSalary"]);
                            model.Deductions = Convert.ToDouble(reader["Deductions"] == DBNull.Value ? default : reader["Deductions"]);
                            model.TaxablePay = Convert.ToDouble(reader["TaxablePay"] == DBNull.Value ? default : reader["TaxablePay"]);
                            model.IncomeTax = Convert.ToDouble(reader["IncomeTax"] == DBNull.Value ? default : reader["IncomeTax"]);
                            model.NetPay = Convert.ToDouble(reader["NetPay"] == DBNull.Value ? default : reader["NetPay"]);
                            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}", model.Id, model.Name, model.Salary, model.StartDate, model.Gender, model.PhoneNumber, model.Department, model.Address, model.BasicSalary, model.Deductions, model.TaxablePay, model.IncomeTax, model.NetPay);
                        }
                    }
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void AddEmployee(EmployeePayroll model)
        {
            try
            {
                connection = new SqlConnection(ConnectionString);
                SqlCommand command = new SqlCommand("dbo.spAddEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", model.Name);
                command.Parameters.AddWithValue("@Address", model.Address);
                command.Parameters.AddWithValue("@Salary", model.Salary);
                command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                command.Parameters.AddWithValue("@Gender", model.Gender);
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result != 0)
                    Console.WriteLine("Employee inserted successfully into table");
                else
                    Console.WriteLine("Not inserted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }
        }


    }

}
