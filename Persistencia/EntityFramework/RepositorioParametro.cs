using ShockSoft.Dominio;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioParametro : Repositorio<Parametro, ShockDbContext>
    {
        public RepositorioParametro(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
