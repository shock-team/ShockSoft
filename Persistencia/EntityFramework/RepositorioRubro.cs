using ShockSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioRubro : Repositorio<Rubro, ShockDbContext>
    {
        public RepositorioRubro(ShockDbContext pDbContext) : base(pDbContext) { }
        public IEnumerable<Rubro> ObtenerRubros(int pDesde, int pCantidad)
        {
            var rubrosFiltrados = (from r in iDbContext.Rubros
                                        select r);
            return rubrosFiltrados.OrderBy(x => x.IdRubro).Skip(pDesde).Take(pCantidad);
        }

        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM rubros";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }
    }
}
