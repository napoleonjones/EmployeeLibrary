using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLibrary.Bad_Examples.Bad_OCP
{
    public class EmployeePayCalculator
    {
        public EmployeePayCalculator()
        {

        }

        public decimal CalculateAllPay(ICollection<Employee> employees)
        {
            var TotalPay = 0M;

            foreach (var employee in employees)
            {
                TotalPay += CalculateEmployeePay(employee);
            }

            return TotalPay;
        }

        public decimal CalculateEmployeePay(Employee employee)
        {
            if (employee.EmployeeType == EmployeeType.Salary)
            {
                return employee.Salary / 26;
                
            }

            return employee.Rate * employee.Hours;
        }
    }
}
