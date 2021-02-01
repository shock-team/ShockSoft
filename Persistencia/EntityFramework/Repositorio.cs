using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ZonaSoft.Persistencia.EntityFramework
{
    public abstract class Repositorio<TEntity, TDbContext> : IRepositorio<TEntity>
           where TEntity : class
           where TDbContext : DbContext
    {
        protected readonly TDbContext iDbContext;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="pDbContext">El contexto de la base de datos.</param>
        public Repositorio(TDbContext pDbContext)
        {
            if (pDbContext == null)
            {
                throw new ArgumentNullException(nameof(pDbContext));
            }

            this.iDbContext = pDbContext;
        }

        /// <summary>
        /// Agrega una entidad genérica a la base de datos.
        /// </summary>
        /// <param name="pEntity"></param>
        public void Agregar(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }

            iDbContext.Set<TEntity>().Add(pEntity);
        }

        /// <summary>
        /// Devuelve una entidad genérica de la base de datos a partir de su <paramref name="pId"/>
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public TEntity Obtener(int pId)
        {
            return this.iDbContext.Set<TEntity>().Find(pId);
        }

        /// <summary>
        /// Devuelve todos los objetos de una base de datos.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TEntity> ObtenerTodos()
        {
            return this.iDbContext.Set<TEntity>().ToList();
        }
    }
}
