using ShockSoft.Dominio;
using System.Collections.Generic;

namespace ShockSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase Producto
    /// y las clases de dominio. Esta clase aplica el patrón de diseño Singleton.
    /// </summary>
    public class ControladorProductos
    {
        public static ControladorProductos instancia;

        /// <summary>
        /// Obtiene la instancia del controlador
        /// </summary>
        /// <returns></returns>
        public static ControladorProductos ObtenerInstancia()
        {
            if (instancia.Equals(null))
            {
                instancia = new ControladorProductos();
            }
            return instancia;
        }

        /// <summary>
        /// Este método se encarga de crear el nuevo producto y agregarlo al repositorio
        /// </summary>
        /// <param name="pDescripcion">La descripción del nuevo producto</param>
        /// <param name="pCantidad">La cantidad inicial del nuevo producto</param>
        /// <param name="pPrecioBaseDolar">El precio base en dólares del nuevo producto</param>
        /// <param name="pEnVenta">Si el nuevo producto se encuentra en venta o no</param>
        /// <param name="pGanancia">El porcentaje de ganancia del nuevo producto</param>
        /// <param name="pIVA">El ID del IVA asociado al nuevo producto</param>
        public void AgregarProducto(string pDescripcion, int pCantidad, float pPrecioBaseDolar, bool pEnVenta, float pGanancia, int pIVA)
        {
            Producto producto = new Producto();
            producto.Descripcion = pDescripcion;
            producto.Cantidad = pCantidad;
            producto.PrecioBaseDolar = pPrecioBaseDolar;
            producto.EnVenta = pEnVenta;
            producto.PorcentajeGanancia = pGanancia;
            IVA iva = new IVA();
            producto.IVA = iva;
        }

        /// <summary>
        /// Este método se encarga de devolver una lista de todos los productos 
        /// presentes en el repositorio, según distintos filtros
        /// </summary>
        /// <returns></returns>
        public List<Producto> ListarProductos()
        {
            List<Producto> listaProductos = new List<Producto>();
            return listaProductos;
        }

        /// <summary>
        /// Este método se encarga de modificar los datos de un producto existente
        /// en el repositorio
        /// </summary>
        /// <param name="pDescripcion">La nueva descripción del producto</param>
        /// <param name="pCantidad">La nueva cantidad del producto</param>
        /// <param name="pPrecioBaseDolar">El nuevo precio base en dólares del producto</param>
        /// <param name="pGanancia">El nuevo porcentaje de ganancia del producto</param>
        /// <param name="pIVA">El ID del nuevo IVA asociado al producto</param>
        /// <param name="idProducto">El ID del producto a modificar</param>
        public void ModificarProducto(string pDescripcion, int pCantidad, float pPrecioBaseDolar, float pGanancia, int pIVA, int idProducto)
        {
            Producto producto = new Producto();
            producto.Descripcion = pDescripcion;
            producto.Cantidad = pCantidad;
            producto.PrecioBaseDolar = pPrecioBaseDolar;
            producto.PorcentajeGanancia = pGanancia;
            IVA iva = new IVA();
            producto.IVA = iva;
        }

        /// <summary>
        /// Este método se encarga de dar de baja un producto existente
        /// </summary>
        /// <param name="idProducto">El ID del producto</param>
        public void DarDeBaja(int idProducto)
        {
            Producto producto = new Producto();
            producto.EnVenta = false;
        }
    }
}