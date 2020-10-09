using ShockSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioLocalidad : Repositorio<Localidad, ShockDbContext>
    {
        public RepositorioLocalidad(ShockDbContext pDbContext) : base(pDbContext) { }

        /// <summary>
        /// Devuelve todas las Localidades de la base de datos.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Localidad> ObtenerTodos()
        {
            return this.iDbContext.Set<Localidad>().ToList();
        }
    }
}
