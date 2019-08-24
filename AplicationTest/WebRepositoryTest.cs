using System;
using System.Collections.Generic;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Repository;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using System.Collections;

namespace AplicationTest
{
    [TestClass]
    public class WebRepositoryTest
    {
        public const string fakeJsonEmployeeResponse = "[{'id':1,'name':'Juan','contractTypeName':'HourlySalaryEmployee','roleId':1,'roleName':'Administrator','roleDescription':null,'hourlySalary':60000.0,'monthlySalary':80000.0},{'id':2,'name':'Sebastian','contractTypeName':'MonthlySalaryEmployee','roleId':2,'roleName':'Contractor','roleDescription':null,'hourlySalary':60000.0,'monthlySalary':80000.0}]";

        [TestMethod]
        public async Task GetEmployeesAsyncTest()
        {
                //Arrange
                List<EmployeeInfoDTO> expected = new List<EmployeeInfoDTO>();
                EmployeeInfoDTO expected1 = new EmployeeInfoDTO();
                expected1.Id = 1;
                expected1.ContractTypeName = "HourlySalaryEmployee";
                expected1.HourlySalary = 60000.0f;
                expected1.MonthlySalary = 80000.0f;
                EmployeeInfoDTO expected2 = new EmployeeInfoDTO();
                expected2.Id = 2;
                expected2.ContractTypeName = "MonthlySalaryEmployee";
                expected2.HourlySalary = 60000.0f;
                expected2.MonthlySalary = 80000.0f;
                expected.Add(expected1);
                expected.Add(expected2);
                //Act
                WebRepository webRepository = new WebRepository("http://masglobaltestapi.azurewebsites.net/api/Employees");
                var actual = await webRepository.GetEmployeesAsync();
            //Assert
            CollectionAssert.AreEqual(expected, actual, new EmployeeDTOComapre());
        }

        [TestMethod]
        public async Task GetEmployeesAsyncFailTest()
        {
            //Arrange
            List<EmployeeInfoDTO> expected = new List<EmployeeInfoDTO>();
            EmployeeInfoDTO expected1 = new EmployeeInfoDTO();
            expected1.Id = 2;
            expected1.ContractTypeName = "HourlySalaryEmployee";
            expected1.HourlySalary = 60000.0f;
            expected1.MonthlySalary = 80000.0f;
            EmployeeInfoDTO expected2 = new EmployeeInfoDTO();
            expected2.Id = 2;
            expected2.ContractTypeName = "MonthlySalaryEmployee";
            expected2.HourlySalary = 60000.0f;
            expected2.MonthlySalary = 80000.0f;
            expected.Add(expected1);
            expected.Add(expected2);
            //Act
            WebRepository webRepository = new WebRepository("http://masglobaltestapi.azurewebsites.net/api/Employees");
            var actual = await webRepository.GetEmployeesAsync();
            //Assert
            CollectionAssert.AreNotEqual(expected, actual, new EmployeeDTOComapre());
        }

        public class EmployeeDTOComapre : IComparer
        {
            public int Compare(EmployeeInfoDTO x, EmployeeInfoDTO y)
            {
                return x.Id.CompareTo(y.Id);
            }

            public int Compare(object x, object y)
            {
                return Compare((EmployeeInfoDTO)x,(EmployeeInfoDTO)y);
            }
        }



    }
}
