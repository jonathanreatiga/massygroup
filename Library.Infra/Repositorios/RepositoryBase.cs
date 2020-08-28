using Library.Domain.InterfaceInfra;
using Library.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Library.Infra.Repositorios
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private ApiContext Db;

        public RepositoryBase(ApiContext db)
        {
            Db = db;
        }

        public T Add(T obj)
        {
            Db.Set<T>().Add(obj);
            Db.SaveChanges();

            return obj;
        }

        public IEnumerable<T> GetAll()
        {
            return Db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return Db.Set<T>().Find(id);
        }

        public void Remove(T obj)
        {
            Db.Set<T>().Remove(obj);
            Db.SaveChanges();
        }

        public void Update(T obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }


    }
}
