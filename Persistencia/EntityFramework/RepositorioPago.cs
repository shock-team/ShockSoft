using ShockSoft.Dominio;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioPago : Repositorio<Pago, ShockDbContext>
    {
        public RepositorioPago(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
