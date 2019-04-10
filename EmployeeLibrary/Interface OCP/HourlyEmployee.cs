using System;
using System.Collections.Generic;
using System.Text;
using EmployeeLibrary.Interface_OCP.Interfaces;

namespace EmployeeLibrary.Interface_OCP
{
    public class HourlyEmployee : Employee, ICalculatePay
    {
        public decimal Rate { get; set; }

        public decimal Hours { get; set; }

        public decimal CalculatePay()
        {
            return Rate * Hours;
        }
    }
}
