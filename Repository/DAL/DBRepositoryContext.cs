using Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Repository.DAL
{
    public class DBRepositoryContext : DbContext
    {
        public DBRepositoryContext() : base("DBRepositoryContext")
        {
        }
        public DbSet<EmployeeInfoDTO> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
