using ShockSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioLocalidad : Repositorio<Localidad, ShockDbContext>
    {
        public RepositorioLocalidad(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
