using Library.Domain.Entidades;
using Library.Domain.Interface;
using Library.Domain.InterfaceInfra;

namespace Library.Domain.Servicios
{
    public class NovedadesNominaService : ServiceBase<NovedadesNomina>, INovedadesNominaService
    {
        private readonly INovedadesNominaRepositorio _repository;

        public NovedadesNominaService(INovedadesNominaRepositorio repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
