using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepositoy
    {
        Task<List<EmployeeInfoDTO>> GetEmployeesAsync();
        Task<EmployeeInfoDTO> SearchEmployeesByIdAsync(int? searchId);
    }
}
