using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAL
{
    public class DBRepositoryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DBRepositoryContext>
    {

        protected override void Seed(DBRepositoryContext context)
        {
            var employees = new List<EmployeeInfoDTO>
            {
            new EmployeeInfoDTO{Id=1,Name="Juan",ContractTypeName="HourlySalaryEmployee",RoleId=1,RoleName="Administrator",RoleDescription=null,HourlySalary=60000.0f,MonthlySalary=80000.0f},
            new EmployeeInfoDTO{Id=2,Name="Sebastian",ContractTypeName="MonthlySalaryEmployee",RoleId=2,RoleName="Contractor",RoleDescription=null,HourlySalary=60000f,MonthlySalary=120000f}
            };
            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
        }
    }

}
