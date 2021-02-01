using ShockSoft.Dominio;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioVenta : Repositorio<Venta, ShockDbContext>
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="pDbContext">El contexto de la base de datos.</param>
        public RepositorioVenta(ShockDbContext pDbContext) : base(pDbContext) { }

        /// <summary>
        /// Este método se utiliza para obtener todas las ventas presentes en la base de datos, filtradas según
        /// distintos criterios.
        /// </summary>
        /// <param name="pIdCliente">El ID del cliente asociado a la venta.</param>
        /// <param name="pIdProducto">El ID de un producto asociado a una de las líneas de la venta.</param>
        /// <param name="pDesde">El índice a partir del cual devolver las ventas.</param>
        /// <param name="pCantidad">La cantidad de ventas a devolver.</param>
        /// <returns></returns>
        public IEnumerable<Venta> ObtenerVentas(int pIdCliente, int pIdProducto, int pDesde, int pCantidad)
        {
            var ventasFiltradas = (from v in iDbContext.Ventas
                                  join lv in iDbContext.LineasDeVentas on v.IdVenta equals lv.IdVenta
                                  where pIdProducto == 0 || lv.IdProducto == pIdProducto &&
                                  pIdCliente == 0 || v.IdCliente == pIdCliente
                                  select v);
            ventasFiltradas = ventasFiltradas.Include("Lineas");
            ventasFiltradas = ventasFiltradas.Include("Cliente");
            ventasFiltradas = ventasFiltradas.Include("MetodoPago");
            return ventasFiltradas.OrderByDescending(x => x.Fecha).Skip(pDesde).Take(pCantidad);
        }

        /// <summary>
        /// Este método se utiliza para obtener la cantidad de ventas presentes en la base de datos.
        /// </summary>
        /// <returns></returns>
        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM ventas";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }

        /// <summary>
        /// Este método se utiliza para obtener una venta en particular a partir de su ID, así como los demás
        /// objetos asociados a esta.
        /// </summary>
        /// <param name="pIdVenta">El ID de la venta a traer.</param>
        /// <returns></returns>
        public Venta ObtenerVentaPorId(int pIdVenta)
        {
            var ventas = (from v in iDbContext.Ventas
                          .Include("Lineas")
                          .Include("Cliente")
                          .Include("MetodoPago")
                          where v.IdVenta == pIdVenta
                          select v);
            return ventas.First();
        }
    }
}
