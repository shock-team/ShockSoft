using ShockSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioVenta : Repositorio<Venta, ShockDbContext>
    {
        public RepositorioVenta(ShockDbContext pDbContext) : base(pDbContext) { }

        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM ventas";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }
    }
}
