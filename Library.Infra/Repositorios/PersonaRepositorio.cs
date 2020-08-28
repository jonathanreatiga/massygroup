using Library.Domain.Entidades;
using Library.Domain.InterfaceInfra;
using Library.Infra.Context;

namespace Library.Infra.Repositorios
{
    public class PersonaRepositorio : RepositoryBase<Persona>, IPersonaRepositorio
    {
        private ApiContext context;

        public PersonaRepositorio(ApiContext db) : base(db)
        {
            context = db;
        }
    }
}
