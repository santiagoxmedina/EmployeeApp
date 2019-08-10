using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepositoy
    {
        Task<List<EmployeeDTO>> GetEmployeesAsync();
        Task<EmployeeDTO> SearchEmployeesByIdAsync(int? searchId);
    }
}
