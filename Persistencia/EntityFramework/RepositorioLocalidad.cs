using ZonaSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ZonaSoft.Persistencia.EntityFramework
{
    public class RepositorioLocalidad : Repositorio<Localidad, ShockDbContext>
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="pDbContext">El contexto de la base de datos.</param>
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

        /// <summary>
        /// Este método se utiliza para obtener todas las localidades presentes en la base de datos.
        /// </summary>
        /// <param name="pDesde">El índice a partir del cual obtener las localidades.</param>
        /// <param name="pCantidad">La cantidad de localidades a devolver.</param>
        /// <returns></returns>
        public IEnumerable<Localidad> ObtenerLocalidades(int pDesde, int pCantidad)
        {
            var localidadesFiltrados = (from l in iDbContext.Localidades
                                        select l);
            return localidadesFiltrados.OrderBy(x => x.IdLocalidad).Skip(pDesde).Take(pCantidad);
        }

        /// <summary>
        /// Este método se utiliza para obtener la cantidad de localidades presentes en la base de datos.
        /// </summary>
        /// <returns></returns>
        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM localidades";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }
    }
}
