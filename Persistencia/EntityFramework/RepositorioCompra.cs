using ShockSoft.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Persistencia.EntityFramework
{
    class RepositorioCompra : Repositorio<Compra, ShockDbContext>
    {
        public RepositorioCompra(ShockDbContext pDbContext) : base(pDbContext) { }


    }
}
