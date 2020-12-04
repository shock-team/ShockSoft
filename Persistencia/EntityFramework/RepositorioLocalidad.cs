using ShockSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioLocalidad : Repositorio<Localidad, ShockDbContext>
    {
        public RepositorioLocalidad(ShockDbContext pDbContext) : base(pDbContext) { }

        /// <summary>
        /// Verifica que no existan localidades con el mismo nombre
        /// </summary>
        /// <param name="pNombre">El nombre a buscar</param>
        /// <returns></returns>
        public IEnumerable<Localidad> VerificarDatos(string pNombre)
        {
            var localidades = (from l in iDbContext.Localidades
                               where l.Nombre.ToUpper().Equals(pNombre.ToUpper())
                               select l);
            return localidades;
        }

        public IEnumerable<Localidad> ObtenerLocalidades(int pDesde, int pCantidad)
        {
            var localidadesFiltrados = (from l in iDbContext.Localidades
                                        select l);
            return localidadesFiltrados.OrderBy(x => x.IdLocalidad).Skip(pDesde).Take(pCantidad);
        }

        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM localidades";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }
    }
}
