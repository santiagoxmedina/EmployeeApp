namespace Models
{
    public class EmployeeHourlySalary : Employee
    {
        public EmployeeHourlySalary(EmployeeDTO employeeDTO) : base(employeeDTO)
        {
            
        }

        public new float GetSalary()
        {
            return HourlySalary * 12 * 120;
        }
    }
}
