using ZonaSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ZonaSoft.Persistencia.EntityFramework
{
    public class RepositorioProveedor : Repositorio<Proveedor, ShockDbContext>
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="pDbContext">El contexto de la base de datos.</param>
        public RepositorioProveedor(ShockDbContext pDbContext) : base(pDbContext) { }

        /// <summary>
        /// Este método se utiliza para obtener todos los proveedores presentes en la base de datos.
        /// </summary>
        /// <param name="pDesde">El índice a partir del cual obtener los proveedores.</param>
        /// <param name="pCantidad">La cantidad de proveedores a devolver.</param>
        /// <returns></returns>
        public IEnumerable<Proveedor> ObtenerProveedores(int pDesde, int pCantidad)
        {
            var proveedoresFiltrados = (from p in iDbContext.Proveedores
                                       select p);
            return proveedoresFiltrados.OrderBy(x => x.IdProveedor).Skip(pDesde).Take(pCantidad);
        }

        /// <summary>
        /// Este método se utiliza para obtener la cantidad de proveedores presentes en la base de datos.
        /// </summary>
        /// <returns></returns>
        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM proveedores";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }

    }
}
