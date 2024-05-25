using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Domain.Model.CompanyAggregate;
using PrimeiraAPI.Domain.Model.EmployeeAggregate;

namespace PrimeiraAPI.Infraestrutura.Repositories
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Company { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

            => optionsBuilder.UseNpgsql(
                "Server=localhost;" +
                "Port=5432; Database =employee_sample;" +
                "User Id=postgres;" +
                "Password=123456;");


    }
}
