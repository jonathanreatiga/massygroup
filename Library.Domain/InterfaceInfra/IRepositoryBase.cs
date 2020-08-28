using System.Collections.Generic;

namespace Library.Domain.InterfaceInfra
{
    public interface IRepositoryBase<TEntity>
    {
        TEntity Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
    }
}
