﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rental.DataAccess;

namespace Rental.DataAccess.Migrations
{
    [DbContext(typeof(RentalContext))]
    [Migration("20190526145921_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Rental.Model.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AvailableStatus");

                    b.Property<string>("CarModel");

                    b.Property<string>("ImgUrl");

                    b.Property<string>("Make");

                    b.Property<int>("NumberOfDoors");

                    b.Property<double>("Price");

                    b.Property<string>("RegistrationNumber");

                    b.HasKey("CarId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            CarId = 1,
                            AvailableStatus = true,
                            CarModel = "Miata",
                            Make = "Mazda",
                            NumberOfDoors = 2,
                            Price = 200.0,
                            RegistrationNumber = "AA12345"
                        },
                        new
                        {
                            CarId = 2,
                            AvailableStatus = false,
                            CarModel = "V70",
                            Make = "Volvo",
                            NumberOfDoors = 4,
                            Price = 400.0,
                            RegistrationNumber = "BB33445"
                        });
                });

            modelBuilder.Entity("Rental.Model.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            FirstName = "Test",
                            LastName = "MadeInContext"
                        },
                        new
                        {
                            CustomerId = 2,
                            FirstName = "Test2",
                            LastName = "MadeInContext2"
                        });
                });

            modelBuilder.Entity("Rental.Model.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("OccupationCode");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Email = "employee1@co.com",
                            FirstName = "Ola",
                            LastName = "Normann",
                            OccupationCode = 0
                        },
                        new
                        {
                            EmployeeId = 2,
                            Email = "employee2@co.com",
                            FirstName = "Kai",
                            LastName = "Vik",
                            OccupationCode = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
