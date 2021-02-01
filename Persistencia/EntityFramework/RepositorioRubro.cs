using ZonaSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ZonaSoft.Persistencia.EntityFramework
{
    public class RepositorioRubro : Repositorio<Rubro, ShockDbContext>
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="pDbContext">El contexto de la base de datos.</param>
        public RepositorioRubro(ShockDbContext pDbContext) : base(pDbContext) { }

        /// <summary>
        /// Este método se utiliza para obtener todos los rubros presentes en la base de datos.
        /// </summary>
        /// <param name="pDesde">El índice a partir del cual obtener los rubros.</param>
        /// <param name="pCantidad">La cantidad de rubros a devolver.</param>
        /// <returns></returns>
        public IEnumerable<Rubro> ObtenerRubros(int pDesde, int pCantidad)
        {
            var rubrosFiltrados = (from r in iDbContext.Rubros
                                        select r);
            return rubrosFiltrados.OrderBy(x => x.IdRubro).Skip(pDesde).Take(pCantidad);
        }

        /// <summary>
        /// Este método se utiliza para obtener la cantidad de rubros presentes en la base de datos.
        /// </summary>
        /// <returns></returns>
        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM rubros";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }
    }
}
