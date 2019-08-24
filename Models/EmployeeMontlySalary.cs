using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class EmployeeMonthlySalary : Employee,IEmployeeSalary
    {
        public new float Salary { get { return GetSalary(); } }
        public EmployeeMonthlySalary(EmployeeInfoDTO employeeDTO) : base(employeeDTO)
        {
        }

        public  float GetSalary()
        {
            return MonthlySalary * 12;
        }
    }
}
