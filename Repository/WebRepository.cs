using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Models;
using Newtonsoft.Json;

namespace Repository
{
    public class WebRepository : IRepositoy
    {
        private string employeesURL;

        public  WebRepository(string _employeesURL)
        {
            employeesURL = _employeesURL;
        }

        public async Task<List<EmployeeDTO>> GetEmployeesAsync()
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri(employeesURL);

                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string textResult = await response.Content.ReadAsStringAsync();
                    var employees = JsonConvert.DeserializeObject<List<EmployeeDTO>>(textResult);
                    return employees;
                }
                else
                {
                    return new List<EmployeeDTO>();
                }
                
            }
            
        }

        public async Task<EmployeeDTO> SearchEmployeesByIdAsync(int? searchId)
        {
            if (searchId == null)
            {
                return null;
            }
       
            List<EmployeeDTO> employeed = await GetEmployeesAsync();
            return employeed.Find(x=>x.Id == searchId.Value);
        }
    }
}
