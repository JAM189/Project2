using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryCSharp.FirstApi.IRepo
{
   public interface IDepartmentService<T> where T:class
    {
        IEnumerable<T> GetAll();
        T GetById(int Id);
    }
}
