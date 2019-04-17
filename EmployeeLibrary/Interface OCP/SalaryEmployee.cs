using EmployeeLibrary.Interface_OCP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLibrary.Interface_OCP
{
    public class SalaryEmployee : Employee, ICalculatePay
    {
        public decimal Salary { get; set; }
        public virtual decimal CalculatePay()
        {
            return Salary / 26;
        }
    }
}
