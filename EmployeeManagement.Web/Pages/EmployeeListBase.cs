using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public bool showHide { get; set; } = true;

        public int SelectedEmployeeCount { get; set; } = 0;

        //To store List of Employees we created the property
        public IEnumerable<Employee> Employees { get; set; }

        protected void EmployeeSelectionChanged(bool isSelected)
        {
            if (isSelected)
                SelectedEmployeeCount++;
            else
                SelectedEmployeeCount--;
        }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }




        ////Hard-coding the list of employees for the demo
        //private void LoadEmployees()
        //{
        //    System.Threading.Thread.Sleep(4000);

        //    Employee e1 = new Employee()
        //    {
        //        EmployeeId = 1,
        //        FirstName = "Chinni",
        //        LastName = "Karthik",
        //        Email = "karthik.chinni95@gmail.com",
        //        Gender = Gender.Male,
        //        DateOfBirth = new DateTime(1992, 06, 22),
        //        DepartmentId = 1,
        //        PhotoPath = "Images/Karthik.jpg"
        //    };
        //    Employee e2 = new Employee()
        //    {
        //        EmployeeId = 2,
        //        FirstName = "Mallineni",
        //        LastName = "Prathap",
        //        Email = "prathap.mallineni@gmail.com",
        //        Gender = Gender.Male,
        //        DateOfBirth = new DateTime(1992, 06, 22),
        //        DepartmentId = 2,
        //        PhotoPath = "Images/Prathap.png"
        //    };
        //    Employee e3 = new Employee()
        //    {
        //        EmployeeId = 3,
        //        FirstName = "Kuridi",
        //        LastName = "Sravanthi",
        //        Email = "sravanthi.kuridi@gmail.com",
        //        Gender = Gender.Male,
        //        DateOfBirth = new DateTime(1992, 10, 08),
        //        DepartmentId = 3,
        //        PhotoPath = "Images/Sravanthi.png"
        //    };

        //    Employees = new List<Employee> { e1, e2, e3 };
        //}

        ////To call the private method using one of the Component Life Cycle method
        //protected override Task OnInitializedAsync()
        //{
        //    //It calls the method that initializes the Employees property
        //    LoadEmployees();
        //    return base.OnInitializedAsync();
        //}

        //To call the private method using one of the Component Life Cycle method
        
        //protected override async Task OnInitializedAsync()
        //{
        //    //It calls the method that initializes the Employees property
        //    await Task.Run(LoadEmployees);
        //}
    
    }
}
