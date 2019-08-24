namespace Models
{
    public class EmployeeHourlySalary : Employee
    {
        public new float Salary { get { return GetSalary(); } }
        public EmployeeHourlySalary(EmployeeInfoDTO employeeDTO) : base(employeeDTO)
        {
            
        }

        public  float GetSalary()
        {
            return HourlySalary * 12 * 120;
        }
    }
}
