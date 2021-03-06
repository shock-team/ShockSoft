﻿using System;

namespace ZonaSoft.Persistencia.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
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
        public RepositorioRubro RepositorioRubro { get; private set; }
        public RepositorioVenta RepositorioVenta { get; private set; }
        public RepositorioParametro RepositorioParametro { get; private set; }
        public RepositorioLineasDeCompras RepositorioLineasDeCompras { get; private set; }
        public RepositorioLineasDeVentas RepositorioLineasDeVentas { get; private set; }
        public RepositorioLineasDeReparaciones RepositorioLineasDeReparaciones { get; private set; }
        public RepositorioCompra RepositorioCompras { get; private set; }

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="pDbContext">El contexto de la base de datos.</param>
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
            this.RepositorioRubro = new RepositorioRubro(pDbContext);
            this.RepositorioVenta = new RepositorioVenta(pDbContext);
            this.RepositorioParametro = new RepositorioParametro(pDbContext);
            this.RepositorioLineasDeCompras = new RepositorioLineasDeCompras(pDbContext);
            this.RepositorioLineasDeVentas = new RepositorioLineasDeVentas(pDbContext);
            this.RepositorioLineasDeReparaciones = new RepositorioLineasDeReparaciones(pDbContext);
            this.RepositorioCompras = new RepositorioCompra(pDbContext);
        }

        /// <summary>
        /// Este método se utiliza para hacer efectivos los cambios realizados sobre la base de datos.
        /// </summary>
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
