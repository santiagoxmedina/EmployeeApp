using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class EmployeeMonthlySalary : Employee
    {
        public EmployeeMonthlySalary(EmployeeDTO employeeDTO) : base(employeeDTO)
        {
        }

        public new float GetSalary()
        {
            return MonthlySalary * 12;
        }
    }
}
