using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeDetailsBase : ComponentBase
    {
        [Inject]
        public IEmployeeService employeeService { get; set; }

        [Parameter]
        public string Id { get; set; }

        public Employee employee { get; set; } = new Employee();

        protected override async Task OnInitializedAsync()
        {
            // If Id value is not supplied in the URL, use the value 1
            Id = Id ?? "1";
            employee = await employeeService.GetEmployee(int.Parse(Id));
        }

    }
}
