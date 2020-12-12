using ShockSoft.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioCompra : Repositorio<Compra, ShockDbContext>
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="pDbContext">El contexto de la base de datos.</param>
        public RepositorioCompra(ShockDbContext pDbContext) : base(pDbContext) { }

        /// <summary>
        /// Este método se utiliza para obtener una compra particular presente en la 
        /// base de datos, junto con sus líneas y proveedor a partir de su ID.
        /// </summary>
        /// <param name="pIdCompra">El ID de la compra a traer</param>
        /// <returns></returns>
        public Compra ObtenerCompraPorId(int pIdCompra)
        {
            var compra = (from c in iDbContext.Compras
                                    .Include("LineasCompra")
                                    .Include("LineasCompra.Producto")
                                    .Include("Proveedor")
                          where c.IdCompra == pIdCompra
                          select c);
            return compra.First();
        }

        /// <summary>
        /// Este método se utiliza para obtener todas las compras presentes en la base de datos, acotadas
        /// en cantidad y que cumplan con ciertos criterios.
        /// </summary>
        /// <param name="pIdProveedor">El ID del proveedor a quien se realizaron las compras.</param>
        /// <param name="pIdProducto">El ID de un producto que contienen las compras.</param>
        /// <param name="pDesde">El índice desde el cual traer las compras.</param>
        /// <param name="pCantidad">La cantidad de preguntas a traer.</param>
        /// <returns></returns>
        public IEnumerable<Compra> ObtenerCompras(int pIdProveedor, int pIdProducto, int pDesde, int pCantidad)
        {
            var comprasFiltradas = (from c in iDbContext.Compras
                                              .Include("LineasCompra")
                                              .Include("LineasCompra.Producto")
                                              .Include("Proveedor")
                                    //join lc in iDbContext.LineasDeCompras on c.IdCompra equals lc.IdCompra
                                    where ((pIdProveedor == 0) || (c.IdProveedor == pIdProveedor)) &&
                                          //((pIdProducto == 0) || (lc.IdProducto == pIdProducto)) &&
                                          (pIdProducto == 0 || c.LineasCompra.Any(x => x.IdProducto == pIdProducto))
                                    select c);
            return comprasFiltradas.Distinct().OrderByDescending(x => x.Fecha).Skip(pDesde).Take(pCantidad);
        }

        /// <summary>
        /// Este método se utiliza para otener la cantidad total de compras presentes en la base de datos.
        /// </summary>
        /// <returns></returns>
        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM compras";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }
    }
}
