using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TryCSharp.FirstApi.IRepo;
using TryCSharp.FirstApi.Models;
using TryCSharp.FirstApi.Repositories;

namespace TryCSharp.FirstApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {   //now created an object to be able to use the generic repo functions and then passed object in the constructor along with already passed student repo)
        private readonly IDepartmentService<Department> _department;

        private readonly IStudentRepository studentRepos;
        //constructor for injection of istudentrepo

        public StudentController(
            IStudentRepository studentRepository, IDepartmentService<Department> Dept
            )
        {
            _department = Dept;
            studentRepos = studentRepository;
        }
        //methods

        [HttpGet]
        public void Get( )
        {
            var listofDept = _department.GetAll(); //can use a funct from generic repo without making sep repo func
           
        }

        [HttpGet]
        public Student Get(int id)
        {   
            return studentRepos.GetStudent(id);
        }

        [HttpPut]
        public void Insert(Student student)
        {
            studentRepos.Insert(student);
        }
    }
}
