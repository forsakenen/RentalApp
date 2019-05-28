using Rental.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace Rental.DataAccess
{
    public class RentalContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public RentalContext(DbContextOptions<RentalContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CreateDummyActors(modelBuilder);
        }

        private static void CreateDummyActors(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(new Customer() { CustomerId = 1, FirstName = "Test", LastName = "MadeInContext" });
            modelBuilder.Entity<Customer>().HasData(new Customer() { CustomerId = 2, FirstName = "Test2", LastName = "MadeInContext2" });

            modelBuilder.Entity<Car>().HasData(new Car() { CarId = 1, AvailableStatus = true, Make = "Mazda", CarModel = "Miata", Price = 200, NumberOfDoors = 2, RegistrationNumber = "AA12345" });
            modelBuilder.Entity<Car>().HasData(new Car() { CarId = 2, AvailableStatus = false, Make = "Volvo", CarModel = "V70", Price = 400, NumberOfDoors = 4, RegistrationNumber = "BB33445" });

            modelBuilder.Entity<Employee>().HasData(new Employee() { EmployeeId = 1, FirstName = "Ola", LastName = "Normann", Email = "employee1@co.com" });
            modelBuilder.Entity<Employee>().HasData(new Employee() { EmployeeId = 2, FirstName = "Kai", LastName = "Vik", Email = "employee2@co.com" });
        }
    }

    public class RentalContextFactory : IDesignTimeDbContextFactory<RentalContext>
    {
        public RentalContext CreateDbContext(string[] args)
        {
            var connection = @"Server=(localdb)\MSSQLLocalDB;Database=Rental.Database;Trusted_Connection=True;ConnectRetryCount=0";

            var optionsBuilder = new DbContextOptionsBuilder<RentalContext>();
            optionsBuilder.UseSqlServer(connection, x => x.MigrationsAssembly("Rental.DataAccess"));

            return new RentalContext(optionsBuilder.Options);
        }
    }
}