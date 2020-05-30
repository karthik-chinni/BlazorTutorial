using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext appDbContext;

        public DepartmentRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Department> GetDepartments()
        {
            return appDbContext.Departments;
        }

        public Department GetDepartment(int deptId)
        {
            return appDbContext.Departments.FirstOrDefault(d => d.DepartmentId == deptId);
        }

    }
}
