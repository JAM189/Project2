using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TryCSharp.FirstApi.Models;

namespace TryCSharp.FirstApi.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private List<Student> studentlist;

        //for construction injection
        private readonly UniversityDBcontext univDB;
        //private readonly Student student;
        public StudentRepository(UniversityDBcontext universityDBcontext)
        {
            univDB = universityDBcontext;
            //studentlist = new List<Student>()
            //{
            //    new Student() { Id = 1, Name = "Mary", Gender = "Female",Department = "HR"},
            //    new Student() { Id = 2, Name = "John", Department = "IT", Gender = "Male" },
            //    new Student() { Id = 3, Name = "Sam", Department = "IT", Gender = "Male" },
            //};
        } 

        public Student GetStudent(int id)
        {
            return this.studentlist.FirstOrDefault(e => e.Id == id);
        }

        public void InsertStudent(Student student)
        {
            univDB.Students.Add(student);
            univDB.SaveChanges();
        }

        public void UpdateStudent(Student student, Student entity)
        {
           student.Id = entity.Id;
           student.Name = entity.Name;
           student.Gender = entity.Gender;
           student.Department = entity.Department;

            univDB.SaveChanges();
        }

        public void DeleteStudent(Student entity)
        {
               univDB.Students.Remove(entity);
               univDB.SaveChanges();
            
        }





        ////method for dept
        //public List<Models.Department> GetDepartments()
        //{
        //    UniversityDBcontext employeeDBContext = new UniversityDBcontext();
        //    return employeeDBContext.Departments.Include("Students").ToList();
        //}
    }
}
