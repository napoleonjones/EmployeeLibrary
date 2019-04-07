using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLibrary.Abstract_OCP
{
    public abstract class Employee
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }
        
        public abstract decimal CalculatePay();
    }
}
