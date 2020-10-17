using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicatie_Salarizare.Models
{
    public class EmployeesRepository : IEmployeesRepository
    {
        public static string _connectionString1 = "Server=DESKTOP-RH29RPI\\SQLEXPRESS;Database=SalaryApp;Trusted_Connection=True;";

        public IEnumerable<Employee> updateEmployee(int id, string lastname, string surname, int base_salary = -1,
             int increase = -1, int gross_prizes = -1, int deductions = -1)
        {
            using var conn = new SqlConnection(_connectionString1);
            try
            {
                conn.Open();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message.ToString(), "Error Message");
            }

            if (lastname != null && !lastname.Equals(""))
            {
                string std1 = "update employees set lastname = @param1 where id = @param2";
                using SqlCommand cmd1 = new SqlCommand(std1, conn);
                {
                    cmd1.Parameters.AddWithValue("@param1", lastname);
                    cmd1.Parameters.AddWithValue("@param2", id);

                    try
                    {
                        cmd1.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.Message.ToString(), "Error Message");
                    }
                }
            }


            if (surname != null && !surname.Equals(""))
            {
                string std2 = "update employees set surname = @param1 where id = @param2";
                using SqlCommand cmd2 = new SqlCommand(std2, conn);
                {
                    cmd2.Parameters.AddWithValue("@param1", surname);
                    cmd2.Parameters.AddWithValue("@param2", id);

                    try
                    {
                        cmd2.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.Message.ToString(), "Error Message");
                    }
                }
            }

            if (base_salary != -1)
            {
                string std3 = "update employees set base_salary = @param1 where id = @param2";
                using SqlCommand cmd3 = new SqlCommand(std3, conn);
                {
                    cmd3.Parameters.AddWithValue("@param1", base_salary);
                    cmd3.Parameters.AddWithValue("@param2", id);

                    try
                    {
                        cmd3.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.Message.ToString(), "Error Message");
                    }
                }
            }

            if (increase != -1)
            {
                string std4 = "update employees set increase = @param1 where id = @param2";
                using SqlCommand cmd4 = new SqlCommand(std4, conn);
                {
                    cmd4.Parameters.AddWithValue("@param1", increase);
                    cmd4.Parameters.AddWithValue("@param2", id);

                    try
                    {
                        cmd4.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.Message.ToString(), "Error Message");
                    }
                }
            }

            if (gross_prizes != -1)
            {
                string std5 = "update employees set gross_prizes = @param1 where id = @param2";
                using SqlCommand cmd5 = new SqlCommand(std5, conn);
                {
                    cmd5.Parameters.AddWithValue("@param1", gross_prizes);
                    cmd5.Parameters.AddWithValue("@param2", id);

                    try
                    {
                        cmd5.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.Message.ToString(), "Error Message");
                    }
                }
            }

            if (deductions != -1)
            {
                string std6 = "update employees set deductions = @param1 where id = @param2";
                using SqlCommand cmd6 = new SqlCommand(std6, conn);
                {
                    cmd6.Parameters.AddWithValue("@param1", deductions);
                    cmd6.Parameters.AddWithValue("@param2", id);

                    try
                    {
                        cmd6.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.Message.ToString(), "Error Message");
                    }
                }
            }
        return GetEmployees();
    }
        public Taxes getTaxes()
        {
            Taxes tax = new Taxes();
            string std = "select * from taxes";

            using var conn = new SqlConnection(_connectionString1);
            using SqlCommand cmd = new SqlCommand(std, conn);
            try
            {
                conn.Open();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message.ToString(), "Error Message");
            }

            SqlDataReader reader = cmd.ExecuteReader();

            tax.Tax = Convert.ToInt32(reader[0]);
            tax.CAS = Convert.ToInt32(reader[1]);
            tax.CASS = Convert.ToInt32(reader[2]);
            tax.password = reader[3].ToString();

            return tax;
        }
        public void AddEmployee(Employee emp)
        {
            string std = "INSERT INTO employees(Lastname, Surname, Position, Base_Salary, Deductions, Gross_Prizes, Increase)" +
                    " VALUES(@param1, @param2, @param3, @param4, @param5, @param6, @param7)";

            using (var conn = new SqlConnection(_connectionString1))
            using (SqlCommand cmd = new SqlCommand(std, conn))
            {
                cmd.Parameters.AddWithValue("@param1", emp.Lastname);
                cmd.Parameters.AddWithValue("@param2", emp.Surname);
                cmd.Parameters.AddWithValue("@param3", emp.Position);
                cmd.Parameters.AddWithValue("@param4", emp.Base_Salary);
                cmd.Parameters.AddWithValue("@param5", emp.Deductions);
                cmd.Parameters.AddWithValue("@param6", emp.Gross_Prizes);
                cmd.Parameters.AddWithValue("@param7", emp.Increase);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message.ToString(), "Error Message");
                }
            }

        }

        public void removeEmployee(int id)
        {
            string std = "delete employees where id = @param1";

            using (var conn = new SqlConnection(_connectionString1))
            using (SqlCommand cmd = new SqlCommand(std, conn))
            {
                cmd.Parameters.AddWithValue("@param1", id);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message.ToString(), "Error Message");
                }
            }
        }

        public IEnumerable<Employee> GetEmployee(string lastname, string surname)
        {
            List<Employee> employees = new List<Employee>();

            string std = "select * from employees where Lastname=@param1 and Surname=@param2";

            using (var conn = new SqlConnection(_connectionString1))
            using (SqlCommand cmd = new SqlCommand(std, conn))
            {
                cmd.Parameters.AddWithValue("@param1", lastname);
                cmd.Parameters.AddWithValue("@param2", surname);

                try
                {
                    conn.Open();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message.ToString(), "Error Message");
                }

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var employee = new Employee();
                    employee.Id = Convert.ToInt32(reader[0]);
                    employee.Lastname = reader[1].ToString();
                    employee.Surname = reader[2].ToString();
                    employee.Position = reader[3].ToString();
                    employee.Base_Salary = Convert.ToInt32(reader[4]);
                    employee.Increase = Convert.ToInt32(reader[5]);
                    employee.Gross_Prizes = Convert.ToInt32(reader[6]);
                    employee.Gross_Total = Convert.ToInt32(reader[7]);
                    employee.Taxable_Gross = Convert.ToInt32(reader[8]);
                    employee.Tax = Convert.ToInt32(reader[9]);
                    employee.CAS = Convert.ToInt32(reader[10]);
                    employee.CASS = Convert.ToInt32(reader[11]);
                    employee.Deductions = Convert.ToInt32(reader[12]);
                    employee.Net_Salary = Convert.ToInt32(reader[13]);

                    employees.Add(employee);
                }
                return employees;
            }
            
        }
        public IEnumerable<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using (var conn = new SqlConnection(_connectionString1))
            using (var cmd = conn.CreateCommand())
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Connection Open ! ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Can not open connection ! " + ex);
                }

                cmd.CommandText = "SELECT * from employees;";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var employee = new Employee();
                    employee.Id = Convert.ToInt32(reader[0]);
                    employee.Lastname = reader[1].ToString();
                    employee.Surname = reader[2].ToString();
                    employee.Position = reader[3].ToString();
                    employee.Base_Salary = Convert.ToInt32(reader[4]);
                    employee.Increase = Convert.ToInt32(reader[5]);
                    employee.Gross_Prizes = Convert.ToInt32(reader[6]);
                    employee.Gross_Total = Convert.ToInt32(reader[7]);
                    employee.Taxable_Gross = Convert.ToInt32(reader[8]);
                    employee.Tax = Convert.ToInt32(reader[9]);
                    employee.CAS = Convert.ToInt32(reader[10]);
                    employee.CASS = Convert.ToInt32(reader[11]);
                    employee.Deductions = Convert.ToInt32(reader[12]);
                    employee.Net_Salary = Convert.ToInt32(reader[13]);

                    employees.Add(employee);
                }
                return employees;
            }
        }
    }
}
