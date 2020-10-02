using ShockSoft.Dominio;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioMarca : Repositorio<Marca, ShockDbContext>
    {
        public RepositorioMarca(ShockDbContext pDbContext) : base(pDbContext) { }
    }
}
