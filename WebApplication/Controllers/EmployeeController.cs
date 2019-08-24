using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        //IRepositoy repository = new WebRepository("http://masglobaltestapi.azurewebsites.net/api/Employees");
        IRepositoy repository = new DBRepository();
        public async System.Threading.Tasks.Task<ActionResult> IndexAsync(int? SearchId)
        {
            ViewBag.SyncOrAsync = "Asynchronous";
            List<EmployeeInfoDTO> employees = new List<EmployeeInfoDTO>();
            if (SearchId != null)
            {
                EmployeeInfoDTO foundedEmployee = await repository.SearchEmployeesByIdAsync(SearchId);
                if (foundedEmployee != null)
                {
                    employees.Add(foundedEmployee);
                }
            }
            else
            {
                employees = await repository.GetEmployeesAsync();
            }
            return View(EmployeeFactory.GetEmployees(employees));
        }

        public async System.Threading.Tasks.Task<ActionResult> EmployeeAsync(int? SearchId)
        {
            ViewBag.SyncOrAsync = "Asynchronous";
            List<EmployeeInfoDTO> employees = new List<EmployeeInfoDTO>();
            if (SearchId != null)
            {
                EmployeeInfoDTO foundedEmployee = await repository.SearchEmployeesByIdAsync(SearchId);
                if (foundedEmployee != null)
                {
                    employees.Add(foundedEmployee);
                }
            }
            else
            {
                employees = await repository.GetEmployeesAsync();
            }
            return View(EmployeeFactory.GetEmployees(employees));
        }
    }
}