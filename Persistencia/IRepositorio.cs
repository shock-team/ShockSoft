using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Persistencia
{
    public interface IRepositorio<TEntity>
        where TEntity : class
    {
        void Agregar(TEntity pEntity);
        TEntity Obtener(int pId);
    }
}
