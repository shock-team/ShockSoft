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
        public RepositorioLocalidad RepositorioLocalidad { get; private set; }
        public RepositorioMarca RepositorioMarca { get; private set; }
        public RepositorioMetodoPago RepositorioMetodoPago { get; private set; }
        public RepositorioPago RepositorioPago { get; private set; }
        public RepositorioProducto RepositorioProducto { get; private set; }
        public RepositorioProveedor RepositorioProveedor { get; private set; }
        public RepositorioReparacion RepositorioReparacion { get; private set; }
        public RepositorioTipoEquipo RepositorioTipoEquipo { get; private set; }
        public RepositorioVenta RepositorioVenta { get; private set; }
        public RepositorioParametro RepositorioParametro { get; private set; }

        public UnitOfWork(ShockDbContext pDbContext)
        {
            if (pDbContext == null)
            {
                throw new ArgumentNullException(nameof(pDbContext));
            }

            this.iDbContext = pDbContext;
            this.RepositorioCliente = new RepositorioCliente(pDbContext);
            this.RepositorioLocalidad = new RepositorioLocalidad(pDbContext);
            this.RepositorioMarca = new RepositorioMarca(pDbContext);
            this.RepositorioMetodoPago = new RepositorioMetodoPago(pDbContext);
            this.RepositorioPago = new RepositorioPago(pDbContext);
            this.RepositorioProducto = new RepositorioProducto(pDbContext);
            this.RepositorioProveedor = new RepositorioProveedor(pDbContext);
            this.RepositorioReparacion = new RepositorioReparacion(pDbContext);
            this.RepositorioTipoEquipo = new RepositorioTipoEquipo(pDbContext);
            this.RepositorioVenta = new RepositorioVenta(pDbContext);
            this.RepositorioParametro = new RepositorioParametro(pDbContext);
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
