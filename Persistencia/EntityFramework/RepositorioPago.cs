using ShockSoft.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Persistencia.EntityFramework
{
    class RepositorioPago : Repositorio<Pago, ShockDbContext>
    {
        public RepositorioPago(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
