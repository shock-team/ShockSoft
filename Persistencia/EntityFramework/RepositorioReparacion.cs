using ShockSoft.Dominio;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioReparacion : Repositorio<Reparacion, ShockDbContext>
    {
        public RepositorioReparacion(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
