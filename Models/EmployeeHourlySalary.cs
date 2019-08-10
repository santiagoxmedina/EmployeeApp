using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class EmployeeHourlySalary : IEmployeeSalary
    {
        private Employee employee;
        public EmployeeHourlySalary(Employee _employee)
        {
            employee = _employee;
        }

        public float GetSalary()
        {
            return employee.HourlySalary * 12 * 120;
        }
    }
}
