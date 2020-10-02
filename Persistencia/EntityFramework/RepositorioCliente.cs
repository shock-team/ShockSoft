using ShockSoft.Dominio;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioCliente : Repositorio<Cliente, ShockDbContext>
    {
        public RepositorioCliente(ShockDbContext pDbContext) : base(pDbContext) { }

    }
}
