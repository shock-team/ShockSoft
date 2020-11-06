using ShockSoft.Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioProducto : Repositorio<Producto, ShockDbContext>
    {
        public RepositorioProducto(ShockDbContext pDbContext) : base(pDbContext) { }

        public IEnumerable<Producto> ObtenerProductos(bool pNoEnVenta, bool pSinStock, string pDescripcion, int pDesde, int pCantidad, int pIdMarca, int pIdRubro)
        {
            var productosFiltrados = (from p in iDbContext.Productos
                                      .Include("Marca")
                                      .Include("Rubro")
                                      where (p.EnVenta || (!p.EnVenta && pNoEnVenta)) &&
                                      (p.Cantidad > 0 || ((p.Cantidad <= 0) && pSinStock)) &&
                                      (string.IsNullOrEmpty(pDescripcion) || p.Descripcion.ToUpper().Contains(pDescripcion.ToUpper())) &&
                                      (pIdMarca == -1 || p.IdMarca == pIdMarca) &&
                                      (pIdRubro == -1 || p.IdRubro == pIdRubro)
                                      select p);

            return productosFiltrados.OrderBy(x => x.Descripcion).Skip(pDesde).Take(pCantidad);
        }

		public IEnumerable<Producto> ObtenerEnVenta(bool pNoEnVenta)
        {
            var prodFiltrados = (from p in iDbContext.Productos.Include("Marca")
                                 where p.EnVenta || p.EnVenta == pNoEnVenta
                                 select p);
            return prodFiltrados;
        }

        public IEnumerable<Producto> ObtenerConStock(bool pSinStock)
        {
            var prodFiltrados = (from p in iDbContext.Productos.Include("Marca")
                                 where p.Cantidad > 0 || ((p.Cantidad == 0) == pSinStock)
                                 select p);
            return prodFiltrados;
        }

        public IEnumerable<Producto> ObtenerPorDescripcion(string pDescripcion)
        {
            var prodFiltrados = (from p in iDbContext.Productos.Include("Marca")
                                 where p.Descripcion.Contains(pDescripcion)
                                 select p);
            return prodFiltrados;
        }

        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM productos";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }
    }
}

