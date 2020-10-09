using ShockSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioMetodoPago : Repositorio<MetodoPago, ShockDbContext>
    {
        public RepositorioMetodoPago(ShockDbContext pDbContext) : base(pDbContext) { }

        /// <summary>
        /// Devuelve todos los Clientes de la base de datos.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MetodoPago> ObtenerTodos()
        {
            return this.iDbContext.Set<MetodoPago>().ToList();
        }
    }
}
