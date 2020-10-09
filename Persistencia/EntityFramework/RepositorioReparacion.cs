using ShockSoft.Dominio;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioReparacion : Repositorio<Reparacion, ShockDbContext>
    {
        public RepositorioReparacion(ShockDbContext pDbContext) : base(pDbContext) { }

        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM reparaciones";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }
    }
}
