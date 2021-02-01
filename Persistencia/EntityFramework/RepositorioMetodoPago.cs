using ZonaSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ZonaSoft.Persistencia.EntityFramework
{
    public class RepositorioMetodoPago : Repositorio<MetodoPago, ShockDbContext>
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="pDbContext">El contexto de la base de datos.</param>
        public RepositorioMetodoPago(ShockDbContext pDbContext) : base(pDbContext) { }

        /// <summary>
        /// Este método se utiliza para obtener la cantidad de métodos de pago presentes en la base
        /// de datos.
        /// </summary>
        /// <returns></returns>
        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM metodosDePago";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }

        /// <summary>
        /// Este método se utiliza para obtener una página de todos los métodos de pago presentes en
        /// la base de datos.
        /// </summary>
        /// <param name="pDesde">El índice a partir del cual obtener los métodos de pago.</param>
        /// <param name="pCantidad">La cantidad de métodos de pago a devolver.</param>
        /// <returns></returns>
        public IEnumerable<MetodoPago> ObtenerMetodosDePago(int pDesde, int pCantidad)
        {
            var metodosDePago = (from m in iDbContext.MetodosDePago
                                 select m);
            return metodosDePago.Skip(pDesde).Take(pCantidad);
        }
    }
}
