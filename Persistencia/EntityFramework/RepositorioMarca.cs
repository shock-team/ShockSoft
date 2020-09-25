using ShockSoft.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Persistencia.EntityFramework
{
    class RepositorioMarca : Repositorio<Marca, ShockDbContext>
    {
        public RepositorioMarca(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
