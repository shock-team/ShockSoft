using ShockSoft.Dominio;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioRubro : Repositorio<Rubro, ShockDbContext>
    {
        public RepositorioRubro(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
