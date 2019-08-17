using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
namespace AplicationTest
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void Salary_ShouldThrow_NotImplementedException()
        {
            EmployeeDTO employeeDTO = new EmployeeDTO();
            employeeDTO.MonthlySalary = 100;
            Employee employee = new Employee(employeeDTO);
            try
            {
               float salary = employee.Salary;
            }
            catch (NotImplementedException ex)
            {
                StringAssert.Contains(ex.Message, Employee.NotImplementedExceptionMessage);
                return;
            }

            Assert.Fail("The expected exception was not thrown.");
        }
    }
}
