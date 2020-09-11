using ShockSoft.Dominio;
using System.Collections.Generic;

namespace ShockSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase Proveedor
    /// y las clases de dominio
    /// </summary>
    public class CotroladorProveedores
    {
        /// <summary>
        /// Este método se encarga de crear el nuevo proveedor y agregarlo al repositorio
        /// </summary>
        /// <param name="pNombre">El nombre del nuevo proveedor</param>
        public void AgregarProveedor(string pNombre)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Nombre = pNombre;
        }

        /// <summary>
        /// Este método se encarga de devolver una lista de todos los proveedores 
        /// presentes en el repositorio
        /// </summary>
        /// <returns></returns>
        public List<Proveedor> ListarProveedores()
        {
            List<Proveedor> listaProveedores = new List<Proveedor>();
            return listaProveedores;
        }

        /// <summary>
        /// Este método se encarga de modificar los datos de un proveedor existente
        /// en el repositorio
        /// </summary>
        /// <param name="pNombre">El nuevo nombre del proveedor</param>
        /// <param name="idProveedor">El ID del proveedor a modificar</param>
        public void ModificarProveedor(string pNombre, int idProveedor)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Nombre = pNombre;
        }
    }
}