using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShockSoft.Dominio;
using ShockSoft.Persistencia.EntityFramework;
using System.Windows.Forms;

namespace ShockSoft.Presentacion.Controladores
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase Compra
    /// y las clases de dominio. Esta clase aplica el patrón de diseño Singleton.
    /// </summary>
    public class ControladorCompras
    {
        private static ControladorCompras _instancia;

        /// <summary>
        /// Obtiene la instancia del controlador
        /// </summary>
        /// <returns></returns>
        public static ControladorCompras ObtenerInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladorCompras();
            }

            return _instancia;
        }

        /// <summary>
        /// Este método se encarga de crear la nueva compra y agregarla al repositorio
        /// </summary>
        /// <param name="pIdProveedor">ID del proveedor correspondiente a la compra</param>
        /// <param name="pFecha">La fecha en que se efectuó la compra</param>
        public int AgregarCompra(int pIdProveedor, DateTime pFecha, float pDolar, float pTotalEnPesos)
        {
            Compra nuevaCompra = new Compra();
            nuevaCompra.Fecha = pFecha;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Proveedor proveedor = bUoW.RepositorioProveedor.Obtener(pIdProveedor);
                    nuevaCompra.Proveedor = proveedor;
                    nuevaCompra.IdProveedor = pIdProveedor;
                    nuevaCompra.DolarProveedor = pDolar;
                    nuevaCompra.CostoTotalPesos = pTotalEnPesos;
                    bUoW.RepositorioCompras.Agregar(nuevaCompra);
                    bUoW.GuardarCambios();
                    return nuevaCompra.IdCompra;
                }
            }
        }

        /// <summary>
        /// Este método se encarga de devolver una lista de todas las compras presentes
        /// en el repositorio, según distintos filtros
        /// </summary>
        /// <param name="pProveedor">El proveedor asociado a las compras.</param>
        /// <param name="pProducto">El producto asociado las compras.</param>
        /// <param name="pDesde">El índice a partir del cual traer las compras.</param>
        /// <param name="pCantidad">La cantidad de compras a traer.</param>
        /// <returns></returns>
        public List<Compra> ListarCompras(int pProveedor, int pProducto, int pDesde, int pCantidad)
        {
            List<Compra> listaDeCompras = new List<Compra>();
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    listaDeCompras = bUoW.RepositorioCompras.ObtenerCompras(pProveedor, pProducto, pDesde, pCantidad).ToList();
                }
            }
            return listaDeCompras;
        }

        /// <summary>
        /// Genera una lista de instancias de la clase LineaCompra a partir de los datos conocidos
        /// por la vista.
        /// </summary>
        /// <param name="pFilas">Las filas de la tabla de la vista.</param>
        /// <param name="pIdCompra">El ID de la compra asociada a las líneas.</param>
        /// <returns></returns>
        public List<LineaCompra> GenerarLineasDeCompra(DataGridViewRowCollection pFilas, int pIdCompra, float pPrecioDolar)
        {
            List<LineaCompra> lineasDeCompra = new List<LineaCompra>();
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    for (int i = 0; i < pFilas.Count; i++)
                    {
                        if (pFilas[i].Cells[0].Value != null)
                        {
                            LineaCompra lineaDeCompra = new LineaCompra();
                            lineaDeCompra.IdProducto = int.Parse(pFilas[i].Cells[0].Value.ToString());
                            lineaDeCompra.Cantidad = int.Parse(pFilas[i].Cells[3].Value.ToString());

                            Producto producto = bUoW.RepositorioProducto.Obtener(int.Parse(pFilas[i].Cells[0].Value.ToString()));
                            producto.Cantidad += lineaDeCompra.Cantidad;

                            lineaDeCompra.Producto = producto;
                            lineaDeCompra.PrecioActual = producto.PrecioBaseDolar * pPrecioDolar;
                            lineaDeCompra.IdCompra = pIdCompra;

                            bUoW.RepositorioLineasDeCompras.Agregar(lineaDeCompra);
                        }
                    }
                    bUoW.GuardarCambios();
                }
            }
            return lineasDeCompra;
        }

        /// <summary>
        /// Este método se utiliza para obtener la cantidad de instancias de la clase Compra presentes
        /// en la base de datos.
        /// </summary>
        /// <returns></returns>
        public int ObtenerCantidadDeCompras()
        {
            int cantidadDeCompras = 0;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    cantidadDeCompras = bUoW.RepositorioCompras.CantidadFilas();
                }
            }
            return cantidadDeCompras;
        }

        /// <summary>
        /// Este método se utiliza para obtener una instancia específica de la clase Compra presente en
        /// la base de datos a partir de su ID.
        /// </summary>
        /// <param name="pIdCompra">El ID de la venta a traer.</param>
        /// <returns></returns>
        public Compra ObtenerCompra(int pIdCompra)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    return bUoW.RepositorioCompras.ObtenerCompraPorId(pIdCompra);
                }
            }
        }
    }
}
