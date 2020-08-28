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
        public void AltaCliente(string pDNI, string pCUIT, string pApellido, string pNombre, string pTelefono, string pDireccion, Localidad pLocalidad)
        {
            Cliente cliente = new Cliente();
            cliente.iDNI = pDNI;
            cliente.iCUIT = pCUIT;
            cliente.iApellido = pApellido;
            cliente.iNombre = pNombre;
            cliente.iTelefono = pTelefono;
            cliente.iDireccion = pDireccion;
            cliente.iLocalidad = pLocalidad;
        }

        public List<Cliente> ListarClientes(string pNombre = null, string pApellido = null, string pCUIT = null, bool pConDeudas, bool pSinDeudas)
        {
            List<Cliente> listaClientes = new List<Cliente>();
            return listaClientes;
        }
    }
}
