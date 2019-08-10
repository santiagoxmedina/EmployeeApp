using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class EmployeeMontlySalary : IEmployeeSalary
    {
        private Employee employee;
        public EmployeeMontlySalary(Employee _employee)
        {
            employee = _employee;
        }

        public float GetSalary()
        {
            return employee.MonthlySalary * 12;
        }
    }
}
