﻿using ShockSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioProducto : Repositorio<Producto, ShockDbContext>
    {
        public RepositorioProducto(ShockDbContext pDbContext) : base(pDbContext) { }

        public IEnumerable<Producto> ObtenerPorParte(int pDesde, int pHasta)
        {
            return this.iDbContext.Set<Producto>().OrderBy(x => x.IdProducto).Skip(pDesde).Take(pHasta);
        }

        public IEnumerable<Producto> ObtenerEnVenta(bool pNoEnVenta)
        {
            var prodFiltrados = (from p in iDbContext.Productos
                                 where p.EnVenta || p.EnVenta == pNoEnVenta
                                 select p);
            return prodFiltrados;
        }

        public IEnumerable<Producto> ObtenerConStock(bool pSinStock)
        {
            var prodFiltrados = (from p in iDbContext.Productos
                                 where p.Cantidad > 0 || ((p.Cantidad == 0) == pSinStock)
                                 select p);
            return prodFiltrados;
        }

        public IEnumerable<Producto> ObtenerPorDescripcion(string pDescripcion)
        {
            var prodFiltrados = (from p in iDbContext.Productos
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

