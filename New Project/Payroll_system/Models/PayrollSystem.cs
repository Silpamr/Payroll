using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_system.Models
{
    public class PayrollSystem
    {
        private List<BaseEmployee> employees = new List<BaseEmployee>();

        public void AddEmployee(BaseEmployee employee)
        {
            employees.Add(employee);
        }

        public void DisplayEmployees()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Role: {employee.GetType().Name}, Salary: {employee.CalculateSalary():C}");
            }
        }

        public decimal CalculateTotalPayroll()
        {
            decimal total = 0;
            foreach (var employee in employees)
            {
                total += employee.CalculateSalary();
            }
            return total;
        }
    }
}
