using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class EmployeeFactory
    {
        public static List<Employee> GetEmployees(List<EmployeeDTO> employees)
        {
            List<Employee> result = new List<Employee>();
            for (int i = 0; i < employees.Count; i++)
            {
                result.Add(GetEmployee(employees[i]));
            }
            return result;
        }

        private static Employee GetEmployee(EmployeeDTO employeeDTO)
        {
            if (employeeDTO.ContractTypeName == "HourlySalaryEmployee")
            {
                return new EmployeeHourlySalary(employeeDTO);
            }
            else if (employeeDTO.ContractTypeName == "MonthlySalaryEmployee")
            {
                return new EmployeeMonthlySalary(employeeDTO);

            }
            return null;
        }
    }
}
