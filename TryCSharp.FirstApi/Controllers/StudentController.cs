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
        private readonly IGenericRepository<Student> _student;

        private readonly IStudentRepository studentRepos;
        //constructor for injection of istudentrepo

        public StudentController(
            IStudentRepository studentRepository
            )
        {

            studentRepos = studentRepository;
           // _student = studentRepository;

        }
        public StudentController(
           IGenericRepository<Student> student
           )
        {

            //studentRepos = studentRepository;
            _student = student;

        }
        //methods

        [HttpGet]
        public void Get()
        {
            var listofStudents = _student.GetAll(); //can use a funct from generic repo without making sep repo func

        }

        [HttpGet]
        public Student Get(int id)
        {
            return studentRepos.GetStudent(id);
        }

        [HttpPut]
        public void Insert(Student student)
        {
            studentRepos.InsertStudent(student);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            if (student == null)
            {
                return BadRequest("Student is Null");
            }
            studentRepos.InsertStudent(student);
            return CreatedAtRoute("Get", new { Id = student.Id }, student);
        }

        // PUT api/<controller>
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Student student)
        {
            if (student == null)
            {
                return BadRequest("Student is null");
            }
            Student studentToUpdate = _student.GetById(id);
            if (studentToUpdate == null)
            {
                return NotFound("Student could not be found");
            }
            studentRepos.UpdateStudent(studentToUpdate, student);
            return NoContent();
        }

        // DELETE api/<controller>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Student student = _student.GetById(id);
            if (student == null)
            {
                return BadRequest("Student is not found");
            }
            studentRepos.DeleteStudent(student);
            return NoContent();
        }
    }
}
