using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
namespace AplicationTest
{
    [TestClass]
    public class EmployeeHourlySalaryTest
    {
        [TestMethod]
        public void Salary_Correct_Amount()
        {
            EmployeeDTO employeeDTO = new EmployeeDTO();
            employeeDTO.HourlySalary = 100;
            int expected = 144000;
            EmployeeHourlySalary employee = new EmployeeHourlySalary(employeeDTO);

            Assert.AreEqual(expected, employee.GetSalary(), 0.001, "employee not salary correctly");
        }
    }
}
