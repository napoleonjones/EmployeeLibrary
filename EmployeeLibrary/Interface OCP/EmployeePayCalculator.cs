using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using EmployeeLibrary.Interface_OCP.Interfaces;

namespace EmployeeLibrary.Interface_OCP
{
    public class EmployeePayCalculator : ICalculateAllPay, ICalculateAllBonuses
    {
        public EmployeePayCalculator()
        {

        }

        public decimal CalculateAllPay(ICollection<ICalculatePay> employees)
        {
            return employees.Sum(x => x.CalculatePay());
        }

        public decimal CalculateAllBonuses(ICollection<ICalculateBonus> employees)
        {
            return employees.Sum(x => x.CalculateBonus());
        }
    }
}
