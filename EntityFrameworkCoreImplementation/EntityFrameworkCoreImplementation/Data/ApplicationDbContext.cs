using EntityFrameworkCoreImplementation.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreImplementation.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }


        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id =1,
                    Name ="sharmin",
                    Position="developer",
                    Salary =25000,
                    email="sharmin@gmail.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "sadia",
                    Position = "tester",
                    Salary = 20000,
                    email = "sadia@gmail.com"
                },
                new Employee
                {
                    Id = 3,
                    Name = "rahim",
                    Position = "manager",
                    Salary = 30000,
                    email = "rahim@gmail.com"
                }
                );
        }

       
    }
}
