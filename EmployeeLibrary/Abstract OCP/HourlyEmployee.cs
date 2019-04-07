using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLibrary.Abstract_OCP
{
    public class HourlyEmployee : Employee
    {
        public decimal Rate { get; set; }

        public decimal Hours { get; set; }
        public override decimal CalculatePay()
        {
            return Rate * Hours;
        }
    }
}
