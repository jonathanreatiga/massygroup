using System.Collections.Generic;

namespace Library.Domain.Interface
{
    public interface IServiceBase<TEntity>
    {
        TEntity Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
    }
}
