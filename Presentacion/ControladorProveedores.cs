using ShockSoft.Dominio;
using ShockSoft.Persistencia.EntityFramework;
using System.Collections.Generic;

namespace ShockSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase Proveedor
    /// y las clases de dominio. Esta clase aplica el patrón de diseño Singleton.
    /// </summary>
    public class CotroladorProveedores
    {
        public static CotroladorProveedores instancia;

        /// <summary>
        /// Obtiene la instancia del controlador
        /// </summary>
        /// <returns></returns>
        public static CotroladorProveedores ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new CotroladorProveedores();
            }
            return instancia;
        }

        /// <summary>
        /// Este método se encarga de crear el nuevo proveedor y agregarlo al repositorio
        /// </summary>
        /// <param name="pNombre">El nombre del nuevo proveedor</param>
        public void AgregarProveedor(string pNombre)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Nombre = pNombre;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    bUoW.RepositorioProveedor.Agregar(proveedor);
                    bUoW.GuardarCambios();
                }
            }
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
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Proveedor proveedor = bUoW.RepositorioProveedor.Obtener(idProveedor);
                    proveedor.Nombre = pNombre;
                    bUoW.GuardarCambios();
                }
            }
            
        }
    }
}