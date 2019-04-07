using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLibrary.Bad_Examples.Bad_OCP
{
    public class Employee
    {
        public EmployeeType EmployeeType { get; set; }

        public decimal Rate { get; set; }

        public decimal Hours { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public Employee()
        {

        }
    }

    public enum EmployeeType
    {
        Hourly = 1,
        Salary = 2
    }
}
