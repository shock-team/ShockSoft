using ShockSoft.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioCliente : Repositorio<Cliente, ShockDbContext>
    {
        public RepositorioCliente(ShockDbContext pDbContext) : base(pDbContext) { }


    }
}
