using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShockSoft.Dominio;

namespace ShockSoft.Presentacion
{
    public class ControladorClientes
    {
        public void AltaCliente(string pDNI, string pCUIT, string pApellido, string pNombre, string pTelefono, string pDireccion, int pLocalidad)
        {
            Cliente cliente = new Cliente();
            cliente.DNI = pDNI;
            cliente.CUIT = pCUIT;
            cliente.Apellido = pApellido;
            cliente.Nombre = pNombre;
            cliente.Telefono = pTelefono;
            cliente.Direccion = pDireccion;
            //cliente.Localidad = pLocalidad;
        }

        public List<Cliente> ListarClientes(bool pConDeudas, bool pSinDeudas, string pNombre = null, string pApellido = null, string pCUIT = null)
        {
            List<Cliente> listaClientes = new List<Cliente>();
            return listaClientes;
        }

        public void ModificarCliente(Cliente pCliente)
        {

        }

        public void RegistrarPago(Cliente pCliente, Pago pPago)
        {
            pCliente.RegistrarPago(pPago);
        }
    }
}
