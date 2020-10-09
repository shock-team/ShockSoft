using ShockSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioParametro : Repositorio<Parametro, ShockDbContext>
    {
        public RepositorioParametro(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
