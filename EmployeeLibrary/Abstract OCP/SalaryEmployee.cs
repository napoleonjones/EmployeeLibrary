﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLibrary.Abstract_OCP
{
    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
        public override decimal CalculatePay()
        {
            return Salary / 26;
        }
    }
}
