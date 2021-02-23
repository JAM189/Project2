using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TryCSharp.FirstApi.Models;

namespace TryCSharp.FirstApi.Repositories
{
    public interface IDepartmentRepository
    {
        Department GetDepartment(int id);
        void InsertDepartment(Department dept);     
        void UpdateDepartment(Department department, Department entity);
        void DeleteDepartment(Department entity);
    }
}
