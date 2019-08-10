using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public float HourlySalary { get; set; }
        public float MonthlySalary { get; set; }
        public float Salary { get { return employeeSalary.GetSalary(); } }

        private IEmployeeSalary employeeSalary;

        public Employee(EmployeeDTO employeeDTO)
        {
            Id = employeeDTO.Id;
            Name = employeeDTO.Name;
            ContractTypeName = employeeDTO.ContractTypeName;
            RoleId = employeeDTO.RoleId;
            RoleName = employeeDTO.RoleName;
            RoleDescription = employeeDTO.RoleDescription;
            HourlySalary = employeeDTO.HourlySalary;
            MonthlySalary = employeeDTO.MonthlySalary;
        }

        public void SetSalaryManager(IEmployeeSalary _employeeSalary)
        {
            employeeSalary = _employeeSalary;
        }
    }
}
