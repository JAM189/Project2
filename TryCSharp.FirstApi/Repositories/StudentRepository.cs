using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TryCSharp.FirstApi.Repositories
{
    public class StudentRepository
    {
        public List<Models.Department> GetDepartments()
        {
            UniversityDBContext employeeDBContext = new UniversityDBContext();
            return employeeDBContext.Departments.Include("Students").ToList();
        }
    }
}
