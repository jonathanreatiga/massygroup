using Library.Domain.Entidades;
using Library.Domain.Interface;
using Library.Domain.InterfaceInfra;

namespace Library.Domain.Servicios
{
    public class TipoNovedadService : ServiceBase<TipoNovedad>, ITipoNovedadService
    {
        private readonly ITipoNovedadRepositorio _repository;

        public TipoNovedadService(ITipoNovedadRepositorio repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
