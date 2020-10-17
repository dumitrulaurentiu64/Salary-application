using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicatie_Salarizare.Models
{
    public interface IEmployeesRepository
    {
        public void removeEmployee(int id);
        public IEnumerable<Employee> GetEmployees();
        public void AddEmployee(Employee emp);
        public IEnumerable<Employee> GetEmployee(string lastname, string surname);

        public IEnumerable<Employee> updateEmployee(int id, string lastname, string surname, int base_salary,
             int increase, int gross_prizes, int deductions);

        public Taxes getTaxes();
    }
}
