using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TryCSharp.FirstApi.IRepo;
using TryCSharp.FirstApi.Models;
using TryCSharp.FirstApi.Repositories;

namespace TryCSharp.FirstApi.GenericRepo
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {   //this class of type T inherits from interface Igenericrepo so now it can access the 2 funct from there getall, getbyid
        //also created an object of Dbclass

        private readonly UniversityDBcontext _universityDB;
        private readonly DbSet<T> entities;

        public GenericRepository(UniversityDBcontext universityDB)
        {
            _universityDB = universityDB;
            entities = _universityDB.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T GetById(int Id)
        {
           // return entities.FirstOrDefault(x=>x.Id);
          return entities.Find(Id);
        }


    }
}
