using ShockSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioMarca : Repositorio<Marca, ShockDbContext>
    {
        public RepositorioMarca(ShockDbContext pDbContext) : base(pDbContext) { }

        public IEnumerable<Marca> VerificarDatos(string pNombre)
        {
            var marcas = (from m in iDbContext.Marcas
                               where m.Descripcion.ToUpper().Equals(pNombre.ToUpper())
                               select m);
            return marcas;
        }

        public IEnumerable<Marca> ObtenerMarcas(int pDesde, int pCantidad)
        {
            var marcas = (from m in iDbContext.Marcas
                          select m);
            return marcas.OrderBy(x => x.Descripcion).Skip(pDesde).Take(pCantidad);
        }

        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM marcas";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }
    }
}
