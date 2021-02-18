using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TryCSharp.FirstApi.Models;
//using System.Data.Entity;

namespace TryCSharp.FirstApi.Repositories
{
    public class UniversityDBcontext : Microsoft.EntityFrameworkCore.DbContext
    {   // DBContext class must inherit from DbContext
        // present in System.Data.Entity namespace
        public UniversityDBcontext()
        {
        }

        //constructor class inheriting from base class, passing unidbcontext as parameter and naming it as options
        public UniversityDBcontext(DbContextOptions<UniversityDBcontext> options) : 
            base(options)
        {
            //options builder coniguration services ....done in the startup.cs instead of a config service method here
            //to use usesqlserver method, micro.sql package was installed
        }
        //for migrations installed Install-Package Microsoft.EntityFrameworkCore.Tools

        //dbset for linking properties of the db mentioned for querying


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=UniversityDB;Trusted_Connection=True;");
        }
        public DbSet<Models.Department> Departments { get; set; }
        public DbSet<Models.Student> Students { get; set; }

      static void nmain(string[] args)
        {
            using (var context = new UniversityDBcontext())
            {

                var std = new Student()
                {
                    Name = "Bill"
                };

                context.Students.Add(std);
                context.SaveChanges();
            }
        } 
    }
}
