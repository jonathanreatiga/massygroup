using Library.Domain.Entidades;
using Library.Domain.InterfaceInfra;
using Library.Infra.Context;

namespace Library.Infra.Repositorios
{
    public class TipoNovedadRepositorio : RepositoryBase<TipoNovedad>, ITipoNovedadRepositorio
    {
        private ApiContext context;

        public TipoNovedadRepositorio(ApiContext db) : base(db)
        {
            context = db;
        }
    }
}
