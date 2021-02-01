using ZonaSoft.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZonaSoft.Persistencia.EntityFramework
{
    public class RepositorioLineasDeCompras : Repositorio<LineaCompra, ShockDbContext>
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="pDbContext">El contexto de la base de datos.</param>
        public RepositorioLineasDeCompras(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
