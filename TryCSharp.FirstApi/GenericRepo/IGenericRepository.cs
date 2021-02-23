using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TryCSharp.FirstApi.Models;

namespace TryCSharp.FirstApi.IRepo
{
   public interface IGenericRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        T GetById(int Id); 
    }
}
