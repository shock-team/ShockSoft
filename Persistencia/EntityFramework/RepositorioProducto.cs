using ZonaSoft.Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ZonaSoft.Persistencia.EntityFramework
{
    public class RepositorioProducto : Repositorio<Producto, ShockDbContext>
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="pDbContext">El contexto de la base de datos.</param>
        public RepositorioProducto(ShockDbContext pDbContext) : base(pDbContext) { }

        /// <summary>
        /// Este método se utiliza para obtener un producto específico presente en la base de datos a partir
        /// de su ID, junto con los demás objetos asociados.
        /// </summary>
        /// <param name="pIdProducto">El ID del producto a obtener.</param>
        /// <returns></returns>
        public Producto ObtenerProducto(int pIdProducto)
        {
            var producto = (from p in iDbContext.Productos
                            .Include("Marca")
                            .Include("Rubro")
                            .Include("Parametro")
                            where p.IdProducto == pIdProducto
                            select p);

            return producto.FirstOrDefault();
        }

        /// <summary>
        /// Este método se utiliza para obtener todos los productos presentes en la base de datos, filtrados según
        /// distintos criterios.
        /// </summary>
        /// <param name="pNoEnVenta">Si el producto no está en venta.</param>
        /// <param name="pSinStock">Si no se posee stock del producto.</param>
        /// <param name="pDescripcion">La descripción del producto.</param>
        /// <param name="pDesde">El índice a partir del cual obtener el producto.</param>
        /// <param name="pCantidad">La cantidad de productos a devolver.</param>
        /// <param name="pIdMarca">El ID de la marca asociada al producto.</param>
        /// <param name="pIdRubro">El ID del rubro asociado al producto.</param>
        /// <returns></returns>
        public IEnumerable<Producto> ObtenerProductos(bool pNoEnVenta, bool pSinStock, string pDescripcion, int pDesde, int pCantidad, int pIdMarca, int pIdRubro)
        {
            var productosFiltrados = (from p in iDbContext.Productos
                                      .Include("Marca")
                                      .Include("Rubro")
                                      .Include("Parametro")
                                      where (p.EnVenta || (!p.EnVenta && pNoEnVenta)) &&
                                      (p.Cantidad > 0 || ((p.Cantidad <= 0) && pSinStock)) &&
                                      (string.IsNullOrEmpty(pDescripcion) || p.Descripcion.ToUpper().Contains(pDescripcion.ToUpper())) &&
                                      (pIdMarca == -1 || p.IdMarca == pIdMarca) &&
                                      (pIdRubro == -1 || p.IdRubro == pIdRubro)
                                      select p);

            return productosFiltrados.OrderBy(x => x.Descripcion).Skip(pDesde).Take(pCantidad);
        }

        /// <summary>
        /// Este método se utiliza para obtener la cantidad de productos presentes en la base de datos.
        /// </summary>
        /// <returns></returns>
        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM productos";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }
    }
}

