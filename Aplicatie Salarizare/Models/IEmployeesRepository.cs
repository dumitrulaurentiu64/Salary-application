using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicatie_Salarizare.Models
{
    public interface IEmployeesRepository
    {
        public void removeEmployee(int id);
        public IEnumerable<Employee> GetEmployees();
        public DataTable GetEmployeeList();
        public void AddEmployee(Employee emp);
        public IEnumerable<Employee> GetEmployeeByLastnameAndSurname(string lastname, string surname);

        public IEnumerable<Employee> GetEmployeeByLastname(string lastname);

        public IEnumerable<Employee> updateEmployee(int id, string lastname, string surname, int base_salary,
             int increase, int gross_prizes, int deductions);
        public DataTable GetEmployeeBySurname(string surname);
        public Taxes getTaxes();

        public void updateTaxes(int cas, int cass, int tax);
    }
}
