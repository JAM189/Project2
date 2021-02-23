using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TryCSharp.FirstApi.Models;

namespace TryCSharp.FirstApi.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private List<Department> deptlist;

        //for construction injection
        private readonly UniversityDBcontext univDB;
        public DepartmentRepository(UniversityDBcontext universityDBcontext)
        {
            univDB = universityDBcontext;
       
        }

        public Department GetDepartment(int id)
        {
            return this.deptlist.FirstOrDefault(e => e.Id == id);
        }

        public void InsertDepartment(Department dept)
        {
            univDB.Departments.Add(dept);
            univDB.SaveChanges();
        }
       
        public void UpdateDepartment(Department dept, Department entity)
        {
            dept.Id = entity.Id;
            dept.Name = entity.Name;
            dept.Location = entity.Location;
            dept.Students = entity.Students;

            univDB.SaveChanges();
        }

        public void DeleteDepartment(Department entity)
        {
            univDB.Departments.Remove(entity);
            univDB.SaveChanges();

        }
    }
}
