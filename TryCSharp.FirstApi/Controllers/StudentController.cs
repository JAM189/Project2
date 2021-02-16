 using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TryCSharp.FirstApi.Models;
using TryCSharp.FirstApi.Repositories;

namespace TryCSharp.FirstApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepos;
        //constructor for injection of istudentrepo
        public StudentController(IStudentRepository studentRepository)
        {
            studentRepos = studentRepository;
        }
        //methods
        public string Index()
        {
            return studentRepos.GetStudent(1).Name;
        }
        public JsonResult Details()
        {
            Student model = studentRepos.GetStudent(1);
            return Json(model);  //was giving error so i changed the inherentence from controller base to only controller
        }

    }
}
