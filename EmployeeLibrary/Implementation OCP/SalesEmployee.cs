using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLibrary.Implementation_OCP
{
    public class SalesEmployee : SalaryEmployee
    {
        public decimal Sales { get; set; }

        public decimal CommissionRate { get; set; }
        public override decimal CalculatePay()
        {
            var regularPay = Salary / 26;

            var bonusPay = CalculateBonus();

            return regularPay + bonusPay;
        }

        public virtual decimal CalculateBonus()
        {
            return Sales * CommissionRate;
        }
    }
}
