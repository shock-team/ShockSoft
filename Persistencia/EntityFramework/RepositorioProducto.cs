using ShockSoft.Dominio;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioProducto : Repositorio<Producto, ShockDbContext>
    {
        public RepositorioProducto(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
