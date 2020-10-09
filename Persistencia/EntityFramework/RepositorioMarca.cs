using ShockSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioMarca : Repositorio<Marca, ShockDbContext>
    {
        public RepositorioMarca(ShockDbContext pDbContext) : base(pDbContext) { }

        /// <summary>
        /// Devuelve todos los Clientes de la base de datos.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Marca> ObtenerTodos()
        {
            return this.iDbContext.Set<Marca>().ToList();
        }
    }
}
