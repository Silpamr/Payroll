using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_system.Models
{
    public abstract class BaseEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BasicPay { get; set; }
        public decimal Allowances { get; set; }

        public abstract decimal CalculateSalary();
    }
}
