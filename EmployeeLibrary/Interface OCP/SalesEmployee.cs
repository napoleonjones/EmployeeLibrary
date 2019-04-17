using EmployeeLibrary.Interface_OCP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLibrary.Interface_OCP
{
    public class SalesEmployee : SalaryEmployee, ICalculatePay, ICalculateBonus
    {
        public decimal Sales { get; set; }

        public decimal CommissionRate { get; set; }

        public override decimal CalculatePay()
        {
            var regularPay = Salary / 26;

            var bonusPay = CalculateBonus();

            return regularPay + bonusPay;
        }

        public decimal CalculateBonus()
        {
            return Sales * CommissionRate;
        }
    }
}
