using ZonaSoft.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace ZonaSoft.Persistencia.EntityFramework
{
    public class RepositorioReparacion : Repositorio<Reparacion, ShockDbContext>
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="pDbContext">El contexto de la base de datos.</param>
        public RepositorioReparacion(ShockDbContext pDbContext) : base(pDbContext) { }

        /// <summary>
        /// Este método se utiliza para listar todas las reparaciones presentes en la base de datos, filtradas
        /// según distintos criterios.
        /// </summary>
        /// <param name="pIdCliente">El ID del cliente asociado a la reparación.</param>
        /// <param name="pFueReparada">Si el equipo fue reparado o no.</param>
        /// <param name="pFueEntregada">Si el equipo fue entregado o no.</param>
        /// <param name="pFueCobrada">Si la reparación fue cobrada o no.</param>
        /// <param name="pDesde">El índice a partir del cual devolver las reparaciones.</param>
        /// <param name="pCantidad">La cantidad de reparaciones a devolver.</param>
        /// <returns></returns>
        public IEnumerable<Reparacion> ObtenerReparaciones(int pIdCliente, bool pFueReparada, bool pFueEntregada, bool pFueCobrada, int pDesde, int pCantidad)
        {
            var listaReparaciones = (from r in iDbContext.Reparaciones
                                     .Include(x => x.Rubro)
                                     .Include(x => x.Cliente)
                                     where (pIdCliente == 0 || r.IdCliente == pIdCliente) &&
                                     (pFueReparada == false || r.FechaReparacion != DateTime.MinValue) &&
                                     (pFueEntregada == false || r.Entregado == true) &&
                                     (pFueCobrada == false || r.Cobrado == true)

                                     select r);

            return listaReparaciones.OrderByDescending(x => x.FechaIngreso).Skip(pDesde).Take(pCantidad);
        }

        /// <summary>
        /// Este método se utiliza para obtener la cantidad de reparaciones presentes en la base de datos.
        /// </summary>
        /// <returns></returns>
        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM reparaciones";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }

        /// <summary>
        /// Este método se utiliza para obtener una reparación en particular a partir de su ID, así como los
        /// demás objetos vinculados a esta.
        /// </summary>
        /// <param name="pIdReparacion">El ID de la reparación a obtener.</param>
        /// <returns></returns>
        public Reparacion ObtenerReparacionPorId(int pIdReparacion)
        {
            var reparacion = (from r in iDbContext.Reparaciones
                              .Include("Rubro")
                              .Include("Cliente")
                              .Include("MetodoPago")
                              .Include("Marca")
                              .Include("LineasReparacion")
                              .Include("LineasReparacion.Producto")
                              where r.IdReparacion == pIdReparacion
                              select r);
            return reparacion.First();
        }
    }
}
