using ZonaSoft.Dominio;

namespace ZonaSoft.Persistencia.EntityFramework
{
    public class RepositorioPago : Repositorio<Pago, ShockDbContext>
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="pDbContext">El contexto de la base de datos.</param>
        public RepositorioPago(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
