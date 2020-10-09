using ShockSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioMetodoPago : Repositorio<MetodoPago, ShockDbContext>
    {
        public RepositorioMetodoPago(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
