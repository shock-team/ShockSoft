using ShockSoft.Dominio;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioVenta : Repositorio<Venta, ShockDbContext>
    {
        public RepositorioVenta(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
