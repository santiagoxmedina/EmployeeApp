using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace AplicationTest
{
    [TestClass]
    public class EmployeeHourlySalaryTest
    {
        [TestMethod]
        [Timeout(TestTimeout.Infinite)]
        public void Salary_Correct_Amount()
        {
            //Arrange
            EmployeeInfoDTO employeeDTO = new EmployeeInfoDTO();
            employeeDTO.HourlySalary = 100;
            int expected = 144000;
            //Act
            EmployeeHourlySalary employee = new EmployeeHourlySalary(employeeDTO);

            //Assert
            Assert.AreEqual(expected, employee.GetSalary(), 0.001, "employee not salary correctly");
        }
    }
}
