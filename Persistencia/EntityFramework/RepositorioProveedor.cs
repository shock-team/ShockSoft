using ShockSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioProveedor : Repositorio<Proveedor, ShockDbContext>
    {
        public RepositorioProveedor(ShockDbContext pDbContext) : base(pDbContext) { }

        public IEnumerable<Proveedor> ObtenerProveedores(int pDesde, int pCantidad)
        {
            var proveedoresFiltrados = (from p in iDbContext.Proveedores
                                       select p);
            return proveedoresFiltrados.OrderBy(x => x.IdProveedor).Skip(pDesde).Take(pCantidad);
        }

        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM proveedores";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }
    }
}
