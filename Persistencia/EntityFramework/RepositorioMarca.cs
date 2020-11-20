using ShockSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioMarca : Repositorio<Marca, ShockDbContext>
    {
        public RepositorioMarca(ShockDbContext pDbContext) : base(pDbContext) { }

        public IEnumerable<Marca> VerificarDatos(string pNombre)
        {
            var marcas = (from m in iDbContext.Marcas
                               where m.Descripcion.ToUpper().Equals(pNombre.ToUpper())
                               select m);
            return marcas;
        }
    }
}
