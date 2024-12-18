using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_system.Models
{
    public class Intern : BaseEmployee
    {
        public decimal Deduction { get; set; }

        public override decimal CalculateSalary()
        {
            return BasicPay + Allowances - Deduction;
        }
    }
}
