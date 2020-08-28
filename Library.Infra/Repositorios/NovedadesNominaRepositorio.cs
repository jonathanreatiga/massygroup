using Library.Domain.Entidades;
using Library.Domain.InterfaceInfra;
using Library.Infra.Context;

namespace Library.Infra.Repositorios
{
    public class NovedadesNominaRepositorio : RepositoryBase<NovedadesNomina>, INovedadesNominaRepositorio
    {
        private ApiContext context;

        public NovedadesNominaRepositorio(ApiContext db) : base(db)
        {
            context = db;
        }
    }
}
