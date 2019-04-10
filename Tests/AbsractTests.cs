using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeLibrary.Abstract_OCP;

namespace Tests
{
    [TestClass]
    public class AbsractTests
    {
        [TestMethod]
        public void CalculatePayTest()
        {
            var employees = new List<Employee>();

            employees.Add(new HourlyEmployee { Hours = 80, Rate = 100 });
            employees.Add(new SalaryEmployee { Salary = 260000 });
            employees.Add(new SalesEmployee { Salary = 260000, CommissionRate = 0.10M, Sales = 10000 });

            var employeePayCalculator = new EmployeePayCalculator();

            var expectedResult = 29000M;
            var actualResult = employeePayCalculator.CalculateAllPay(employees);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
