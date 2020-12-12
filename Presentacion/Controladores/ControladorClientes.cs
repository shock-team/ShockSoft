using ShockSoft.Dominio;
using ShockSoft.Persistencia.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using ShockSoft.Excepciones;

namespace ShockSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase Cliente
    /// y las clases de dominio. Esta clase aplica el patrón de diseño Singleton.
    /// </summary>
    public class ControladorClientes
    {

        private static ControladorClientes _instancia;

        /// <summary>
        /// Obtiene la instancia del controlador
        /// </summary>
        /// <returns></returns>
        public static ControladorClientes ObtenerInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladorClientes();
            }

            return _instancia;
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
            cliente.Apellido = pApellido;
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
        /// <param name="pDesde">La posición inicial de la lista desde la cual traer</param>
        /// <param name="pCantidad">La cantidad de clientes a traer</param>
        /// <returns></returns>
        public List<Cliente> ListarClientes(bool pConDeudas, bool pSinDeudas, string pNombre, string pApellido, int pDesde, int pCantidad)
        {
            List<Cliente> listaDeClientes = new List<Cliente>();
            List<Cliente> listaDeClientesFiltrados = new List<Cliente>();

            //Trae los clientes de la base de datos
            using (var pDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(pDbContext))
                {
                    listaDeClientes = bUoW.RepositorioCliente.ObtenerClientes(pNombre, pApellido).ToList();
                }
            }

            //Filtra a los clientes en base a si tienen deudas o no
            foreach (Cliente cliente in listaDeClientes)
            {
                if (((cliente.ObtenerSaldo() == 0) && pSinDeudas) || ((cliente.ObtenerSaldo() > 0) && pConDeudas))
                {
                    listaDeClientesFiltrados.Add(cliente);
                }
            }

            //Asigna las ventas 
            return listaDeClientesFiltrados.OrderBy(x => x.Apellido).Skip(pDesde).Take(pCantidad).ToList();
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
                    cliente = bUoW.RepositorioCliente.ObtenerClientePorId(pId);
                }
            }
            return cliente;
        }

        /// <summary>
        /// Este método se encarga de devolver la cantidad de clientes presentes
        /// en la base de datos.
        /// </summary>
        /// <returns></returns>
        public int ObtenerCantidadDeClientes()
        {
            int cantidad = 0;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    cantidad = bUoW.RepositorioCliente.CantidadFilas();
                }
            }
            return cantidad;
        }

        /// <summary>
        /// Verifica que no exista en la base de datos un cliente con el DNI y CUIT especificados
        /// </summary>
        /// <param name="pDNI">El DNI a verificar</param>
        /// <param name="pCUIT">El CUIT a verificar</param>
        public void VerificarDatos(string pDNI, string pCUIT)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    IEnumerable<Cliente> clientes = bUoW.RepositorioCliente.VerificarInformacion(pDNI, pCUIT);
                    if (clientes.Count() > 0)
                    {
                        throw new DatosRepetidosException();
                    }
                }
            }
        }
    }
}
