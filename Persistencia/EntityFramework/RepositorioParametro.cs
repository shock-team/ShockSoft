using ShockSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioParametro : Repositorio<Parametro, ShockDbContext>
    {
        public RepositorioParametro(ShockDbContext pDbContext) : base(pDbContext) { }

        public IEnumerable<Parametro> ObtenerParametros(int pDesde, int pCantidad)
        {
            var parametrosFiltrados = (from p in iDbContext.Parametros
                                       select p);
            return parametrosFiltrados.OrderBy(x => x.IdParametro).Skip(pDesde).Take(pCantidad);
        }

        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM parametros";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }
    }
}
