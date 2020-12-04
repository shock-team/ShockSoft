using ShockSoft.Dominio;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioVenta : Repositorio<Venta, ShockDbContext>
    {
        public RepositorioVenta(ShockDbContext pDbContext) : base(pDbContext) { }

        public IEnumerable<Venta> ObtenerPorCliente(int pIdCliente)
        {
            var ventasFiltradas = (from v in iDbContext.Ventas
                                   join c in iDbContext.Clientes on v.IdCliente equals c.IdCliente
                                   where c.IdCliente == pIdCliente
                                   select v);
            return ventasFiltradas;
        }

        public IEnumerable<Venta> ObtenerPorProducto(int pIdProducto)
        {
            var ventasFiltradas = (from v in iDbContext.Ventas
                                   join lv in iDbContext.LineasDeVentas on v.IdVenta equals lv.IdVenta
                                   where lv.IdProducto == pIdProducto
                                   select v);
            return ventasFiltradas;
        }

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
            return ventasFiltradas.OrderBy(x => x.Fecha).Skip(pDesde).Take(pCantidad);
        }

        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM ventas";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }

        public IEnumerable<Venta> ObtenerUltimaVenta()
        {
            var ventas = (from v in iDbContext.Ventas
                          select v);
            return ventas.OrderByDescending(x => x.IdVenta).Take(1);
        }

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

        public IEnumerable<Venta> ObtenerVentasPorCliente(int pIdCliente)
        {
            var ventas = (from v in iDbContext.Ventas
                          .Include("Lineas")
                          .Include("MetodoPago")
                          where v.IdCliente == pIdCliente
                          select v);
            return ventas.Distinct();
        }
    }
}
