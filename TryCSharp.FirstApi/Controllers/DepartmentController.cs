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
    public class DepartmentController : ControllerBase
    {
        //now created an object to be able to use the generic repo functions and then passed object in the constructor along with already passed student repo)
        private readonly IGenericRepository<Department> _department;
        private readonly IDepartmentRepository dR;

        public DepartmentController(
           IGenericRepository<Department> Dept
           )
        {
            _department = Dept;
            dR = (IDepartmentRepository)Dept;

        }

        [HttpGet]
        public void Get()
        {
            var listofDept = _department.GetAll(); //can use a funct from generic repo without making sep repo func

        }

        [HttpGet]
        public Department Get(int id)
        {
            return _department.GetById(id);   //using g method located in generic
        }

        [HttpPut]
        public void Insert(Department dept) => dR.InsertDepartment(dept);

        [HttpPost]
        public IActionResult Post([FromBody] Department dept)
        {
            if (dept == null)
            {
                return BadRequest("Department is Null");
            }
           dR.InsertDepartment(dept);
            return CreatedAtRoute("Get", new { Id = dept.Id }, dept);
        }

        // PUT api/<controller>
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Department dept)
        {
            if (dept == null)
            {
                return BadRequest("Department is null");
            }
            Department deptToUpdate = _department.GetById(id);
            if (deptToUpdate == null)
            {
                return NotFound("Department could not be found");
            }
            dR.UpdateDepartment(deptToUpdate, dept);
            return NoContent();
        }

        // DELETE api/<controller>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Department dept = _department.GetById(id);
            if (dept == null)
            {
                return BadRequest("Department is not found");
            }
            dR.DeleteDepartment(dept);
            return NoContent();
        }



    }
}
