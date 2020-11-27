﻿using ShockSoft.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioReparacion : Repositorio<Reparacion, ShockDbContext>
    {
        public RepositorioReparacion(ShockDbContext pDbContext) : base(pDbContext) { }

        public IEnumerable<Reparacion> ObtenerReparaciones(int pIdCliente, bool pFueReparada, bool pFueEntregada, bool pFueCobrada, int pDesde, int pCantidad)
        {
            var listaReparaciones = (from r in iDbContext.Reparaciones.Include("Rubro")
                                     join c in iDbContext.Clientes on r.IdCliente equals c.IdCliente
                                     where pIdCliente == 0 || r.IdCliente == pIdCliente &&
                                     pFueReparada == false || r.FechaReparacion != DateTime.MinValue &&
                                     pFueEntregada == false || r.Entregado == true &&
                                     pFueCobrada == false || r.Cobrado == true

                                     select r);
            return listaReparaciones.OrderBy(x => x.FechaIngreso).Skip(pDesde).Take(pCantidad);

        }

        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM reparaciones";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }
    }
}
