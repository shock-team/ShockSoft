using ShockSoft.Dominio;
using System;
using System.Collections.Generic;

namespace ShockSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase Reparación
    /// y las clases de dominio. Esta clase aplica el patrón de diseño Singleton.
    /// </summary>
    public class ControladorReparaciones
    {
        public static ControladorReparaciones instancia;

        /// <summary>
        /// Obtiene la instancia del controlador
        /// </summary>
        /// <returns></returns>
        public static ControladorReparaciones ObtenerInstancia()
        {
            if (instancia.Equals(null))
            {
                instancia = new ControladorReparaciones();
            }
            return instancia;
        }

        /// <summary>
        /// Este método se encarga de crear la nueva reparación y agregarla al repositorio
        /// </summary>
        /// <param name="pProblema">El problema de la nueva reparación</param>
        /// <param name="pFechaIngreso">La fecha de ingreso de la nueva reparación</param>
        /// <param name="pContraseña">La contraseña del dispositivo de la nueva reparación</param>
        /// <param name="pCargador">Si el dispositivo de la nueva reparación incluye cargador o no</param>
        /// <param name="pCables">Si el dispositivo de la nueva reparación incluye cables o no</param>
        /// <param name="pCliente">El ID del cliente asociado a la nueva reparación</param>
        /// <param name="pSolucion">La solución para la nueva reparación</param>
        /// <param name="pFechaReparacion">La fecha en que el dispositivo fue reparado</param>
        /// <param name="pPrecio">El precio de la nueva reparación</param>
        /// <param name="pEntregado">Si el dispositivo reparado fue entregado o no</param>
        /// <param name="pTipoEquipo">El tipo del equipo correspondiente a la nueva reparación</param>
        /// <param name="pMarcaEquipo">La marca del equipo correspondiente a la nueva reparación</param>
        /// <param name="pMetodoPago">El método de pago elegido para la nueva reparación</param>
        /// <param name="pProductosUtilizados">Los productos utilizados en la nueva reparación</param>
        public void AgregarReparacion(string pProblema, DateTime pFechaIngreso, string pContraseña, bool pCargador, bool pCables, int pCliente, string pSolucion, DateTime pFechaReparacion, float pPrecio, bool pEntregado, int pTipoEquipo, int pMarcaEquipo, int pMetodoPago, List<Producto> pProductosUtilizados)
        {
            Reparacion reparacion = new Reparacion();
            reparacion.Problema = pProblema;
            reparacion.FechaIngreso = pFechaIngreso;
            reparacion.Contraseña = pContraseña;
            reparacion.Cargador = pCargador;
            reparacion.Cables = pCables;
            Cliente cliente = new Cliente();
            reparacion.Cliente = cliente;
            reparacion.Solucion = pSolucion;
            reparacion.FechaReparacion = pFechaReparacion;
            reparacion.Precio = pPrecio;
            reparacion.Entregado = pEntregado;
            Marca marca = new Marca();
            reparacion.Marca = marca;
            TipoEquipo tipo = new TipoEquipo();
            reparacion.TipoEquipo = tipo;
            MetodoPago metodoPago = new MetodoPago();
            reparacion.MetodoPago = metodoPago;
            reparacion.Productos = pProductosUtilizados;
        }

        /// <summary>
        /// Este método se encarga de devolver una lista de todas las reparaciones presentes
        /// en el repositorio, según distintos filtros
        /// </summary>
        /// <param name="esPendiente">Si las reparaciones listadas incluyen a las pendientes o no</param>
        /// <param name="esFinalizada">Si las reparaciones listadas incluyen a las finalizadas o no</param>
        /// <param name="esPaga">Si las reparaciones listadas incluyen a las pagas o no</param>
        /// <returns></returns>
        public List<Reparacion> ListarReparaciones(bool esPendiente, bool esFinalizada, bool esPaga)
        {
            List<Reparacion> listaReparaciones = new List<Reparacion>();
            return listaReparaciones;
        }

        /// <summary>
        /// Este método se encarga de modificar los datos de una reparación existente
        /// en el repositorio
        /// </summary>
        /// <param name="pProblema">El nuevo problema de la reparación</param>
        /// <param name="pContraseña">La nueva contraseña de la reparación</param>
        /// <param name="pCargador">Si el dispositivo de la reparación incluye cargador o no</param>
        /// <param name="pCables">Si el dispositivo de la reparación incluye cables o no</param>
        /// <param name="pSolucion">La nueva solución de la reparación</param>
        /// <param name="pFechaReparacion">La nueva fecha de reparación</param>
        /// <param name="pPrecio">El nuevo precio de la reparación</param>
        /// <param name="pEntregado">Si la reparación fue entregada o no</param>
        /// <param name="pMetodoPago">El nuevo método de pago de la reparación</param>
        /// <param name="pProductosUtilizados">Los nuevos productos untilizados en la reparación</param>
        public void ModificarReparacion(string pProblema, string pContraseña, bool pCargador, bool pCables, string pSolucion, DateTime pFechaReparacion, float pPrecio, bool pEntregado, int pMetodoPago, List<Producto> pProductosUtilizados)
        {
            Reparacion reparacion = new Reparacion();
            reparacion.Problema = pProblema;
            reparacion.Contraseña = pContraseña;
            reparacion.Cargador = pCargador;
            reparacion.Cables = pCables;
            reparacion.Solucion = pSolucion;
            reparacion.FechaReparacion = pFechaReparacion;
            reparacion.Precio = pPrecio;
            reparacion.Entregado = pEntregado;
            MetodoPago metodoPago = new MetodoPago();
            reparacion.MetodoPago = metodoPago;
            reparacion.Productos = pProductosUtilizados;
        }
    }
}