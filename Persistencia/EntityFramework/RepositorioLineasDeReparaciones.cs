using ShockSoft.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioLineasDeReparaciones : Repositorio<LineaReparacion, ShockDbContext>
    {
        public RepositorioLineasDeReparaciones(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
