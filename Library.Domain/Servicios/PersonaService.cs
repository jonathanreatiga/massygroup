using Library.Domain.Entidades;
using Library.Domain.Interface;
using Library.Domain.InterfaceInfra;

namespace Library.Domain.Servicios
{
    public class PersonaService : ServiceBase<Persona>, IPersonaService
    {
        private readonly IPersonaRepositorio _repository;

        public PersonaService(IPersonaRepositorio repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
