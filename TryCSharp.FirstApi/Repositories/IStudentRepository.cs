using TryCSharp.FirstApi.Models;

namespace TryCSharp.FirstApi.Repositories
{
    public interface IStudentRepository
    {
        Student GetStudent(int ID);
        void Insert(Student student);
      
    }
}