using ShockSoft.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioLocalidad : Repositorio<Localidad, ShockDbContext>
    {
        public RepositorioLocalidad(ShockDbContext pDbContext) : base(pDbContext) { }

        /// <summary>
        /// Verifica que no existan localidades con el mismo nombre
        /// </summary>
        /// <param name="pNombre">El nombre a buscar</param>
        /// <returns></returns>
        public IEnumerable<Localidad> VerificarDatos(string pNombre)
        {
            var localidades = (from l in iDbContext.Localidades
                               where l.Nombre.ToUpper().Equals(pNombre.ToUpper())
                               select l);
            return localidades;
        }
    }
}
