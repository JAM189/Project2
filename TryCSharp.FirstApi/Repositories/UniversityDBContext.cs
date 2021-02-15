using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Data.Entity;

namespace TryCSharp.FirstApi.Repositories
{
    public class UniversityDBcontext : Microsoft.EntityFrameworkCore.DbContext
    {

        // DBContext class must inherit from DbContext
        // present in System.Data.Entity namespace

        public DbSet<Models.Department> Departments { get; set; }
        public DbSet<Models.Student> Students { get; set; }
    }
}
