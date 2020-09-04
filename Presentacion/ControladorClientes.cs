using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShockSoft.Dominio;

namespace ShockSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase Cliente
    /// y las clases de dominio
    /// </summary>
    public class ControladorClientes
    {
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
        public void AltaCliente(string pDNI, string pCUIT, string pApellido, string pNombre, string pTelefono, string pDireccion, int pLocalidad)
        {
            Cliente cliente = new Cliente();
            cliente.DNI = pDNI;
            cliente.CUIT = pCUIT;
            cliente.Apellido = pApellido;
            cliente.Nombre = pNombre;
            cliente.Telefono = pTelefono;
            cliente.Direccion = pDireccion;
            Localidad localidad = new Localidad();
            cliente.Localidad = localidad;
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
        public List<Cliente> ListarClientes(bool pConDeudas, bool pSinDeudas, string pNombre = null, string pApellido = null, string pCUIT = null)
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
            Cliente cliente = new Cliente();
            cliente.DNI = pDNI;
            cliente.CUIT = pCUIT;
            cliente.Apellido = pApellido;
            cliente.Nombre = pNombre;
            cliente.Telefono = pTelefono;
            cliente.Direccion = pDireccion;
            Localidad localidad = new Localidad();
            cliente.Localidad = localidad;
        }

        /// <summary>
        /// Este método se encarga de registrar un pago a un cliente
        /// </summary>
        /// <param name="idCliente">El id del cliente</param>
        /// <param name="pMonto">El monto a pagar</param>
        public void RegistrarPago(int idCliente, float pMonto)
        {
            Cliente cliente = new Cliente();
            Pago pago = new Pago();
            cliente.RegistrarPago(pago);
        }
    }
}
