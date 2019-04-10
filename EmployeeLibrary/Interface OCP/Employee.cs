using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLibrary.Interface_OCP
{
    public abstract class Employee
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }
    }
}
