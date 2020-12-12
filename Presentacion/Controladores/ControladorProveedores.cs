using ShockSoft.Dominio;
using ShockSoft.Persistencia.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase Proveedor
    /// y las clases de dominio. Esta clase aplica el patrón de diseño Singleton.
    /// </summary>
    public class ControladorProveedores
    {
        private static ControladorProveedores _instancia;

        /// <summary>
        /// Obtiene la instancia del controlador
        /// </summary>
        /// <returns></returns>
        public static ControladorProveedores ObtenerInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladorProveedores();
            }

            return _instancia;
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
        /// <param name="pDesde">El índice a partir del cual obtener los proveedores.</param>
        /// <param name="pCantidad">La cantidad de proveedores a devolver.</param>
        /// <returns></returns>
        public List<Proveedor> ListarProveedores(int pDesde, int pCantidad)
        {
            List<Proveedor> listaProveedores;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    listaProveedores = bUoW.RepositorioProveedor.ObtenerProveedores(pDesde,pCantidad).ToList();
                }
            }
            return listaProveedores;
        }

        /// <summary>
        /// Este método se encarga de modificar los datos de un proveedor existente
        /// en el repositorio
        /// </summary>
        /// <param name="pNombre">El nuevo nombre del proveedor</param>
        /// <param name="idProveedor">El ID del proveedor a modificar</param>
        public void ModificarProveedor(int idProveedor, string pNombre)
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

        /// <summary>
        /// Este método se utiliza para obtener la cantidad total de instancias de la clase Proveedor
        /// presentes en la base de datos.
        /// </summary>
        /// <returns></returns>
        public int ObtenerCantidadDeProveedores()
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    return bUoW.RepositorioProveedor.CantidadFilas();
                }
            }
        }

        /// <summary>
        /// Este método se utiliza para obtener todas las instancias de la clase Proveedor presentes en
        /// la base de datos.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Proveedor> ObtenerProveedores()
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    return bUoW.RepositorioProveedor.ObtenerTodos();
                }
            }
        }
    }
}