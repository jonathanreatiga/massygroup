using Library.Domain.Interface;
using Library.Domain.InterfaceInfra;
using System.Collections.Generic;

namespace Library.Domain.Servicios
{
    public class ServiceBase<T> : IServiceBase<T>
    {
        private readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public T Add(T obj)
        {
            return _repository.Add(obj);
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(T obj)
        {
            _repository.Remove(obj);
        }

        public void Update(T obj)
        {
            _repository.Update(obj);
        }
    }
}
