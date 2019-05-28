using Rental.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;

namespace Rental.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rent me!");

            var connection = @"Server=(localdb)\MSSQLLocalDB;Database=Rental.Database;Trusted_Connection=True;ConnectRetryCount=0";
            var optionsBuilder = new DbContextOptionsBuilder<RentalContext>();
            optionsBuilder.UseSqlServer(connection);

            {
                using (var db = new RentalContext(optionsBuilder.Options))
                {
                    //db.Customers.Add(new Customer { FirstName = "Kai", LastName = "Vik"});
                    //var count = db.SaveChanges();
                    //Console.WriteLine("{0} records saved to database", count);

                    Console.WriteLine();
                    Console.WriteLine("All customers in database:");

                    foreach (var customer in db.Customers)
                    {
                        Console.WriteLine(" - {0}, ID: {1}", customer.FullName, customer.CustomerId);
                    }

                    Console.WriteLine("All cars in database:");

                    foreach (var car in db.Cars)
                    {
                        Console.WriteLine(" - {0}, Reg: {1}", car.FullCar, car.RegistrationNumber);
                    }

                    Console.WriteLine("All employees in database:");

                    foreach (var employee in db.Employees)
                    {
                        Console.WriteLine(" - {0}, ID: {1}", employee.FullName, employee.EmployeeId);
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}