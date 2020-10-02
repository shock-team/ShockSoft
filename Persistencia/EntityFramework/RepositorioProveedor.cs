using ShockSoft.Dominio;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioProveedor : Repositorio<Proveedor, ShockDbContext>
    {
        public RepositorioProveedor(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
