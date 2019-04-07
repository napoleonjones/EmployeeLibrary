using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLibrary.Implementation_OCP
{
    public class Employee
    {
        public decimal Rate { get; set; }

        public decimal Hours { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public Employee()
        {

        }

        public virtual decimal CalculatePay()
        {
            return Rate * Hours;
        }
    }
}
