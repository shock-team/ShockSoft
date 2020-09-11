using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ShockDbContext iDbContext;
        private bool iDisposedValue = false;

        public RepositorioCliente RepositorioCliente { get; private set; }

        public UnitOfWork(ShockDbContext pDbContext)
        {
            if (pDbContext == null)
            {
                throw new ArgumentNullException(nameof(pDbContext));
            }

            this.iDbContext = pDbContext;
            this.RepositorioCliente = new RepositorioCliente(pDbContext);
        }

        public void GuardarCambios()
        {
            this.iDbContext.SaveChanges();
        }

        protected virtual void Dispose(bool pDisposing)
        {
            if (!this.iDisposedValue)
            {
                if (pDisposing)
                {
                    this.iDbContext.Dispose();
                }

                this.iDisposedValue = true;
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
        }
    }
}
