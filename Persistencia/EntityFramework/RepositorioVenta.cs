using ShockSoft.Dominio;
using System.Collections.Generic;
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

        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM ventas";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }
    }
}
