using ShockSoft.Dominio;
using ShockSoft.Persistencia.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ShockSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase Reparación
    /// y las clases de dominio. Esta clase aplica el patrón de diseño Singleton.
    /// </summary>
    public class ControladorReparaciones
    {
        private static ControladorReparaciones _instancia;

        /// <summary>
        /// Obtiene la instancia del controlador
        /// </summary>
        /// <returns></returns>
        public static ControladorReparaciones ObtenerInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladorReparaciones();
            }

            return _instancia;
        }

        ///<summary>
        /// Este método se encarga de crear la nueva reparación y agregarla al repositorio
        /// </summary>
        /// <param name="pProblema">El problema de la nueva reparación</param>
        /// <param name="pSolucion">La solución de la reparación</param>
        /// <param name="pFechaIngreso">La fecha de ingreso de la nueva reparación</param>
        /// <param name="pFechaReparacion">La fecha de reparación del equipo</param>
        /// <param name="pFechaEntrega">La fecha de entrega del equipo</param>
        /// <param name="pContraseña">La contraseña del dispositivo de la nueva reparación</param>
        /// <param name="pCargador">Si el dispositivo de la nueva reparación incluye cargador o no</param>
        /// <param name="pCables">Si el dispositivo de la nueva reparación incluye cables o no</param>
        /// <param name="pCliente">El ID del cliente asociado a la nueva reparación</param>
        /// <param name="pTipoEquipo">El tipo del equipo correspondiente a la nueva reparación</param>
        /// <param name="pMarcaEquipo">La marca del equipo correspondiente a la nueva reparación</param>
        /// <param name="pEntregado">Si el equipo fue entregado o no</param>
        /// <param name="pMetodoPago">El método de pago seleccionado para la reparación</param>
        /// <param name="pPrecio">El precio del trabajo de reparación</param>
        public int AgregarReparacion(string pProblema, string pSolucion, DateTime pFechaIngreso, DateTime pFechaReparacion, DateTime pFechaEntrega, string pContraseña, bool pCargador, bool pCables, string pCliente, int pTipoEquipo, int pMarcaEquipo, bool pEntregado, int pMetodoPago, string pPrecio)
        {
            Reparacion reparacion = new Reparacion();

            reparacion.Problema = pProblema;
            reparacion.Solucion = pSolucion;

            reparacion.FechaIngreso = pFechaIngreso;
            reparacion.FechaReparacion = pFechaReparacion;
            reparacion.FechaEntrega = pFechaEntrega;

            reparacion.Contraseña = pContraseña;
            reparacion.Cargador = pCargador;
            reparacion.Cables = pCables;
            reparacion.Entregado = pEntregado;

            reparacion.LineasReparacion = new List<LineaReparacion>();
            reparacion.Precio = float.Parse(pPrecio);
            
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Cliente cliente = bUoW.RepositorioCliente.Obtener(int.Parse(pCliente));
                    reparacion.IdCliente = cliente.IdCliente;
                    reparacion.Cliente = cliente;

                    Marca marca = bUoW.RepositorioMarca.Obtener(pMarcaEquipo);
                    reparacion.Marca = marca;
                    reparacion.IdMarca = pMarcaEquipo;

                    Rubro tipo = bUoW.RepositorioRubro.Obtener(pTipoEquipo);
                    reparacion.Rubro = tipo;
                    reparacion.IdRubro = pTipoEquipo;

                    MetodoPago metodoDePago = bUoW.RepositorioMetodoPago.Obtener(pMetodoPago);
                    reparacion.MetodoPago = metodoDePago;
                    reparacion.IdMetodoPago = pMetodoPago;

                    bUoW.RepositorioReparacion.Agregar(reparacion);
                    bUoW.GuardarCambios();
                    return reparacion.IdReparacion;
                }
            }
        }

        /// <summary>
        /// Este método se encarga de devolver una lista de todas las reparaciones presentes
        /// en el repositorio, según distintos filtros
        /// </summary>
        /// <param name="pFueReparada">Si las reparaciones listadas incluyen a las reparadas o no</param>
        /// <param name="pFueEntregada">Si las reparaciones listadas incluyen a las entregadas o no</param>
        /// <param name="pFueCobrada">Si las reparaciones listadas incluyen a las pagas o no</param>
        /// <param name="pDesde">El número de reparación a partir del cual mostrar</param>
        /// <param name="pCantidad">La cantidad de reparaciones a mostrar</param>
        /// <returns></returns>
        public List<Reparacion> ListarReparaciones(int pIdCliente, bool pFueReparada, bool pFueEntregada, bool pFueCobrada, int pDesde, int pCantidad)
        {
            List<Reparacion> listaReparaciones;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    listaReparaciones = bUoW.RepositorioReparacion.ObtenerReparaciones(pIdCliente, pFueReparada,pFueEntregada,pFueCobrada,pDesde,pCantidad).ToList();
                }
            }
            return listaReparaciones;
        }

        ///<summary>
        /// Este método se utiliza para modificar los datos de una reparación existente en la base de datos.
        /// </summary>
        /// <param name="pProblema">El problema de la reparación</param>
        /// <param name="pSolucion">La solución de la reparación</param>
        /// <param name="pFechaIngreso">La fecha de ingreso de la reparación</param>
        /// <param name="pFechaReparacion">La fecha de reparación del equipo</param>
        /// <param name="pFechaEntrega">La fecha de entrega del equipo</param>
        /// <param name="pContraseña">La contraseña del dispositivo de la reparación</param>
        /// <param name="pCargador">Si el dispositivo de la reparación incluye cargador o no</param>
        /// <param name="pCables">Si el dispositivo de la reparación incluye cables o no</param>
        /// <param name="pCliente">El ID del cliente asociado a la reparación</param>
        /// <param name="pRubro">El rubro del equipo correspondiente a la reparación</param>
        /// <param name="pMarcaEquipo">La marca del equipo correspondiente a la reparación</param>
        /// <param name="pEntregado">Si el equipo fue entregado o no</param>
        /// <param name="pMetodoPago">El método de pago seleccionado para la reparación</param>
        /// <param name="pPrecio">El precio del trabajo de reparación</param>
        /// <param name="pIdReparacion">El ID de la reparación a modificar</param>
        public void ModificarReparacion(string pProblema, string pSolucion, DateTime pFechaIngreso, DateTime pFechaReparacion, DateTime pFechaEntrega, string pContraseña, bool pCargador, bool pCables, string pCliente, int pRubro, int pMarcaEquipo, bool pEntregado, int pMetodoPago, string pPrecio, int pIdReparacion)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Reparacion reparacion = bUoW.RepositorioReparacion.Obtener(pIdReparacion);

                    reparacion.Problema = pProblema;
                    reparacion.Solucion = pSolucion;

                    reparacion.Contraseña = pContraseña;
                    reparacion.Cargador = pCargador;
                    reparacion.Cables = pCables;
                    reparacion.Entregado = pEntregado;

                    reparacion.FechaIngreso = pFechaIngreso;
                    reparacion.FechaReparacion = pFechaReparacion;
                    reparacion.FechaEntrega = pFechaEntrega;

                    reparacion.Precio = float.Parse(pPrecio);

                    MetodoPago metodoPago = bUoW.RepositorioMetodoPago.Obtener(pMetodoPago);
                    reparacion.MetodoPago = metodoPago;
                    reparacion.IdMetodoPago = pMetodoPago;

                    Cliente cliente = bUoW.RepositorioCliente.Obtener(int.Parse(pCliente));
                    reparacion.Cliente = cliente;
                    reparacion.IdCliente = cliente.IdCliente;

                    Rubro rubro = bUoW.RepositorioRubro.Obtener(pRubro);
                    reparacion.Rubro = rubro;
                    reparacion.IdRubro = pRubro;

                    Marca marca = bUoW.RepositorioMarca.Obtener(pMarcaEquipo);
                    reparacion.Marca = marca;
                    reparacion.IdMarca = pMarcaEquipo;

                    bUoW.GuardarCambios();
                }
            }
        }

        /// <summary>
        /// Este método se utiliza para obtener el número de reparaciones presente en la base de datos.
        /// </summary>
        /// <returns></returns>
        public int ObtenerCantidadReparaciones()
        {
            int cantidad = 0;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    cantidad = bUoW.RepositorioReparacion.CantidadFilas();
                }
            }
            return cantidad;
        }

        /// <summary>
        /// Genera una lista de instancias de la clase LineaReparacion a partir de los datos conocidos, o modifica
        /// los valores de líneas actuales en una reparación existente.
        /// </summary>
        /// <param name="pFilas">Las filas de la tabla a transformar en una lista de líneas.</param>
        /// <param name="pIdReparacion">El ID de la reparación a la cual se asignan las líneas.</param>
        /// <returns></returns>
        public List<LineaReparacion> GenerarLineasDeReparacion(DataGridViewRowCollection pFilas, int pIdReparacion)
        {
            List<LineaReparacion> lineasDeReparacion = new List<LineaReparacion>();
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Reparacion reparacionActual = bUoW.RepositorioReparacion.ObtenerReparacionPorId(pIdReparacion);
                    List<LineaReparacion> lineasActuales = reparacionActual.LineasReparacion.ToList();
                    float precioDolar = ControladorParametros.ObtenerInstancia().ObtenerPrecioDolar();
                    int indiceLineaExistente;
                    int idProducto;
                    LineaReparacion lineaDeReparacion;
                    for (int i = 0; i < pFilas.Count; i++)
                    {
                        if (pFilas[i].Cells[0].Value != null)
                        {
                            idProducto = int.Parse(pFilas[i].Cells[0].Value.ToString());
                            Producto producto = bUoW.RepositorioProducto.Obtener(idProducto);
                            int cantidad = int.Parse(pFilas[i].Cells[3].Value.ToString());

                            //Busca si la reparación ya posee una línea con ese producto.
                            indiceLineaExistente = lineasActuales.FindIndex(x => x.IdProducto == idProducto);

                            //Si no encuentra la línea existente, genera una nueva y la agrega.
                            if (indiceLineaExistente == -1)
                            {
                                lineaDeReparacion = new LineaReparacion();
                                lineaDeReparacion.IdProducto = idProducto;
                                lineaDeReparacion.Cantidad = cantidad;
                                lineaDeReparacion.Producto = producto;
                                lineaDeReparacion.IdReparacion = pIdReparacion;
                                lineaDeReparacion.PrecioActual = producto.PrecioBaseDolar * precioDolar;
                                bUoW.RepositorioLineasDeReparaciones.Agregar(lineaDeReparacion);
                            }

                            //Si la encuentra, modifica sus valores actuales.
                            else
                            {
                                lineaDeReparacion = lineasActuales[indiceLineaExistente];
                                cantidad -= lineaDeReparacion.Cantidad;
                                lineaDeReparacion.Cantidad += cantidad;
                                lineaDeReparacion.PrecioActual = producto.PrecioBaseDolar * precioDolar;
                            }
                            producto.Cantidad -= cantidad;
                        }
                    }
                    bUoW.GuardarCambios();
                }
            }
            return lineasDeReparacion;
        }

        /// <summary>
        /// Este método se utiliza para obtener una reparación presente en la base de datos a partir
        /// de su ID.
        /// </summary>
        /// <param name="pIdReparacion">El ID de la reparación a buscar.</param>
        /// <returns></returns>
        public Reparacion ObtenerReparacion(int pIdReparacion)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Reparacion reparacion = bUoW.RepositorioReparacion.ObtenerReparacionPorId(pIdReparacion);
                    return reparacion;
                }
            }
        }
    }
}