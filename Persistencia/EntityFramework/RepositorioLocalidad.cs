using ShockSoft.Dominio;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioLocalidad : Repositorio<Localidad, ShockDbContext>
    {
        public RepositorioLocalidad(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
