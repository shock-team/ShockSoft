﻿using ShockSoft.Dominio;
using ShockSoft.Persistencia.EntityFramework;
using System;
using System.Collections.Generic;

namespace ShockSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase Cliente
    /// y las clases de dominio. Esta clase aplica el patrón de diseño Singleton.
    /// </summary>
    public class ControladorClientes
    {

        public static ControladorClientes instancia;

        /// <summary>
        /// Obtiene la instancia del controlador
        /// </summary>
        /// <returns></returns>
        public static ControladorClientes ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ControladorClientes();
            }
            return instancia;
        }

        /// <summary>
        /// Este método se encarga de crear el nuevo cliente y agregarlo al repositorio
        /// </summary>
        /// <param name="pDNI">El DNI del nuevo cliente</param>
        /// <param name="pCUIT">El CUIT del nuevo cliente</param>
        /// <param name="pApellido">El apellido del nuevo cliente</param>
        /// <param name="pNombre">El nombre del nuevo cliente</param>
        /// <param name="pTelefono">El teléfono del nuevo cliente</param>
        /// <param name="pDireccion">La dirección del nuevo cliente</param>
        /// <param name="pLocalidad">ID de la localidad del nuevo cliente</param>
        public void AltaCliente(string pDNI, string pCUIT, string pApellido, string pNombre, string pTelefono, string pDireccion, int pIdLocalidad)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = pNombre;
            cliente.Telefono = pTelefono;
            cliente.Direccion = pDireccion;
            cliente.DNI = pDNI;
            cliente.CUIT = pCUIT;
            cliente.Pagos = new List<Pago>();
            cliente.Ventas = new List<Venta>();
            using (var pDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(pDbContext))
                {
                    Localidad localidad = bUoW.RepositorioLocalidad.Obtener(pIdLocalidad);
                    cliente.Localidad = localidad;
                    bUoW.RepositorioCliente.Agregar(cliente);
                    bUoW.GuardarCambios();
                }
            }
        }

        /// <summary>
        /// Este método se encarga de devolver una lista de todos los clientes 
        /// presentes en el repositorio, según distintos filtros
        /// </summary>
        /// <param name="pConDeudas">Indica si se deben incluir los clientes con deuda</param>
        /// <param name="pSinDeudas">Indica si se deben incluir los clientes sin deuda</param>
        /// <param name="pNombre">El nombre por el cual filtrar los clientes</param>
        /// <param name="pApellido">El apellido por el cual filtrar los clientes</param>
        /// <param name="pCUIT">El CUIT por el cual filtrar los clientes</param>
        /// <returns></returns>
        public List<Cliente> ListarClientes(bool pConDeudas, bool pSinDeudas, string pNombre = null, string pApellido = null)
        {
            List<Cliente> listaClientes = new List<Cliente>();
            return listaClientes;
        }

        /// <summary>
        /// Este método se encarga de modificar los datos de un cliente existente
        /// en el repositorio
        /// </summary>
        /// <param name="pDNI">El nuevo DNI del cliente</param>
        /// <param name="pCUIT">El nuevo CUIT del cliente</param>
        /// <param name="pApellido">El nuevo apellido del cliente</param>
        /// <param name="pNombre">El nuevo nombre del cliente</param>
        /// <param name="pTelefono">El nuevo teléfono del cliente</param>
        /// <param name="pDireccion">La nueva dirección del cliente</param>
        /// <param name="pLocalidad">El ID de la nueva localidad del cliente</param>
        /// <param name="idCliente">El ID del cliente a modificar</param>
        public void ModificarCliente(string pDNI, string pCUIT, string pApellido, string pNombre, string pTelefono, string pDireccion, int pLocalidad, int idCliente)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Cliente cliente = bUoW.RepositorioCliente.Obtener(idCliente);
                    cliente.DNI = pDNI;
                    cliente.CUIT = pCUIT;
                    cliente.Apellido = pApellido;
                    cliente.Nombre = pNombre;
                    cliente.Telefono = pTelefono;
                    cliente.Direccion = pDireccion;
                    Localidad localidad = bUoW.RepositorioLocalidad.Obtener(pLocalidad);
                    cliente.Localidad = localidad;
                    bUoW.GuardarCambios();
                }
            }
        }

        /// <summary>
        /// Este método se encarga de registrar un pago a un cliente
        /// </summary>
        /// <param name="pIdCliente">El id del cliente</param>
        /// <param name="pMonto">El monto a pagar</param>
        public void RegistrarPago(int pIdCliente, float pMonto, DateTime pFecha, string pDescripcion)
        {
            Pago pago = new Pago();
            pago.Monto = pMonto;
            pago.Fecha = pFecha;
            pago.Descripcion = pDescripcion;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Cliente cliente = bUoW.RepositorioCliente.Obtener(pIdCliente);
                    cliente.RegistrarPago(pago);
                    bUoW.GuardarCambios();
                }
            }

        }

        /// <summary>
        /// Este método se encarga de obtener y devolver la instancia de un cliente
        /// que se encuentra almacenada en la base de datos.
        /// </summary>
        /// <param name="pId">El Id del cliente que se desea obtener</param>
        /// <returns></returns>
        public Cliente ObtenerCliente(int pId)
        {
            Cliente cliente = new Cliente();
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    cliente = bUoW.RepositorioCliente.Obtener(pId);
                }
            }
            return cliente;
        }
    }
}
