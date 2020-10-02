using ShockSoft.Dominio;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioTipoEquipo : Repositorio<TipoEquipo, ShockDbContext>
    {
        public RepositorioTipoEquipo(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
