using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 1, DepartmentName = "Developer" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 2, DepartmentName = "Support" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 3, DepartmentName = "Testing" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 4, DepartmentName = "Admin" });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Chinni",
                LastName = "Karthik",
                Email = "karthik.chinni95@gmail.com",
                DateOfBirth = new DateTime(1992, 06, 22),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "Images/Karthik.jpg"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "Kuridi",
                LastName = "Sravanthi",
                Email = "sravanthi.kuridi@gmail.com",
                DateOfBirth = new DateTime(1990, 05, 23),
                Gender = Gender.Female,
                DepartmentId = 2,
                PhotoPath = "Images/Sravanthi.png"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "Mallineni",
                LastName = "Prathap",
                Email = "prathap.mallineni@gmail.com",
                DateOfBirth = new DateTime(1992, 05, 20),
                Gender = Gender.Male,
                DepartmentId = 3,
                PhotoPath = "Images/Prathap.png"
            });
        }
    }
}
