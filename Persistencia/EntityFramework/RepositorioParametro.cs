using ShockSoft.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Persistencia.EntityFramework
{
    class RepositorioParametro : Repositorio<Parametro, ShockDbContext>
    {
        public RepositorioParametro(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
