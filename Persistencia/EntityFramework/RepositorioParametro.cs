using ShockSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioParametro : Repositorio<Parametro, ShockDbContext>
    {
        public RepositorioParametro(ShockDbContext pDbContext) : base(pDbContext) { }

        /// <summary>
        /// Devuelve todos los Clientes de la base de datos.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Parametro> ObtenerTodos()
        {
            return this.iDbContext.Set<Parametro>().ToList();
        }
    }
}
