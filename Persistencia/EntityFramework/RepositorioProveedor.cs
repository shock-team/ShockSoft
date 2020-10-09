using ShockSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioProveedor : Repositorio<Proveedor, ShockDbContext>
    {
        public RepositorioProveedor(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
