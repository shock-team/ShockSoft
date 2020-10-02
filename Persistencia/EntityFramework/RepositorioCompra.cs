using ShockSoft.Dominio;

namespace ShockSoft.Persistencia.EntityFramework
{
    class RepositorioCompra : Repositorio<Compra, ShockDbContext>
    {
        public RepositorioCompra(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
