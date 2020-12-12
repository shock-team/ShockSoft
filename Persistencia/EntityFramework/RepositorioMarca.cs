using ShockSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioMarca : Repositorio<Marca, ShockDbContext>
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="pDbContext">El contexto de la base de datos.</param>
        public RepositorioMarca(ShockDbContext pDbContext) : base(pDbContext) { }

        /// <summary>
        /// Este método se utiliza para verificar que no exista una marca con el mismo nombre que el
        /// de una que se desee agregar a la base de datos.
        /// </summary>
        /// <param name="pNombre">El nombre de la marca a agregar.</param>
        /// <returns></returns>
        public IEnumerable<Marca> VerificarDatos(string pNombre)
        {
            var marcas = (from m in iDbContext.Marcas
                               where m.Descripcion.ToUpper().Equals(pNombre.ToUpper())
                               select m);
            return marcas;
        }

        /// <summary>
        /// Este método se utiliza para listar todas las marcas presentes en la base de datos.
        /// </summary>
        /// <param name="pDesde">El índice a partir del cual obtener las marcas.</param>
        /// <param name="pCantidad">La cantidad de marcas a devolver.</param>
        /// <returns></returns>
        public IEnumerable<Marca> ObtenerMarcas(int pDesde, int pCantidad)
        {
            var marcas = (from m in iDbContext.Marcas
                          select m);
            return marcas.OrderBy(x => x.Descripcion).Skip(pDesde).Take(pCantidad);
        }

        /// <summary>
        /// Este método se utiliza para obtener la cantidad de marcas presentes en la base de datos.
        /// </summary>
        /// <returns></returns>
        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM marcas";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }
    }
}
