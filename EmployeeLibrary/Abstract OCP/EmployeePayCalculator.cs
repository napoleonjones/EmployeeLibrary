using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeLibrary.Abstract_OCP
{
    public class EmployeePayCalculator
    {
        public EmployeePayCalculator()
        {

        }

        public decimal CalculateAllPay(ICollection<Employee> employees)
        {
            return employees.Sum(x => x.CalculatePay());
        }        
    }
}
