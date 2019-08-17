using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
namespace AplicationTest
{
    [TestClass]
    public class EmployeeMonthlySalaryTest
    {
        [TestMethod]
        public void Salary_Correct_Amount()
        {
            EmployeeDTO employeeDTO = new EmployeeDTO();
            employeeDTO.MonthlySalary = 100;
            int expected = 1200;
            EmployeeMonthlySalary employee = new EmployeeMonthlySalary(employeeDTO);

            Assert.AreEqual(expected, employee.GetSalary(), 0.001, "employee not salary correctly");
        }
    }
}
