using ShockSoft.Dominio;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioMetodoPago : Repositorio<MetodoPago, ShockDbContext>
    {
        public RepositorioMetodoPago(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
