using ShockSoft.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioTipoEquipo : Repositorio<TipoEquipo, ShockDbContext>
    {
        public RepositorioTipoEquipo(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
