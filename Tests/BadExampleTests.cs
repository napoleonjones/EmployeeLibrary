using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EmployeeLibrary.Bad_Examples.Bad_OCP;

namespace Tests
{
    [TestClass]
    public class BadExampleTests
    {
        [TestMethod]
        public void CalculatePayTest()
        {
            var employees = new List<Employee>();

            employees.Add(new Employee { EmployeeType = EmployeeType.Hourly, Hours = 80, Rate = 100 });
            employees.Add(new Employee { EmployeeType = EmployeeType.Salary, Rate = 260000 });

            var employeePayCalculator = new EmployeePayCalculator();

            var expectedResult = 18000M;
            var actualResult = employeePayCalculator.CalculateAllPay(employees);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
