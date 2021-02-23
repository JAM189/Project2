using TryCSharp.FirstApi.Models;

namespace TryCSharp.FirstApi.Repositories
{
    public interface IStudentRepository
    {
        Student GetStudent(int ID);
        void InsertStudent(Student student);
        void UpdateStudent(Student student, Student entity);
        void DeleteStudent(Student entity);


    }
}