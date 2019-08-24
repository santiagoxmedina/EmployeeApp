using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository.DAL;

namespace Repository
{
    public class DBRepository : IRepositoy
    {
        public DBRepository(){
            
        }
        public Task<List<EmployeeInfoDTO>> GetEmployeesAsync()
        {
            using (DBRepositoryContext db = new DBRepositoryContext()){
                var result = db.Employees.ToList();
                return Task.FromResult(result);
            }
        }

        public Task<EmployeeInfoDTO> SearchEmployeesByIdAsync(int? searchId)
        {
            using (DBRepositoryContext db = new DBRepositoryContext())
            {
                var result = (from p in db.Employees where p.Id == searchId.Value select p)?.First();
                return Task.FromResult(result);
            }
        }
    }
}
