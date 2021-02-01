using ZonaSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ZonaSoft.Persistencia.EntityFramework
{
    public class RepositorioParametro : Repositorio<Parametro, ShockDbContext>
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="pDbContext">El contexto de la base de datos.</param>
        public RepositorioParametro(ShockDbContext pDbContext) : base(pDbContext) { }

        /// <summary>
        /// Este método se utiliza para obtener todos los parámetros presentes en la base de datos.
        /// </summary>
        /// <param name="pDesde">El índice a partir del cual obtener los parámetros.</param>
        /// <param name="pCantidad">La cantidad de parámetros a devolver.</param>
        /// <returns></returns>
        public IEnumerable<Parametro> ObtenerParametros(int pDesde, int pCantidad)
        {
            var parametrosFiltrados = (from p in iDbContext.Parametros
                                       select p);
            return parametrosFiltrados.OrderBy(x => x.IdParametro).Skip(pDesde).Take(pCantidad);
        }

        /// <summary>
        /// Este método se utiliza para obtener el parámetro que representa al precio del dólar.
        /// </summary>
        /// <returns></returns>
        public Parametro ObtenerPrecioDolar()
        {
            return iDbContext.Parametros.Where(x => x.IdParametro == 1).FirstOrDefault();
        }

        /// <summary>
        /// Este método se utiliza para obtener la cantidad de parámetros presentes en la base de datos.
        /// </summary>
        /// <returns></returns>
        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM parametros";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }
    }
}
