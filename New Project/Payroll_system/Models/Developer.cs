using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_system.Models
{
    public class Developer : BaseEmployee
    {
        public override decimal CalculateSalary()
        {
            return BasicPay + Allowances;
        }
    }
}
