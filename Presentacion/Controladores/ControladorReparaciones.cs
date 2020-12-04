﻿using ShockSoft.Dominio;
using ShockSoft.Persistencia.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;

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

        /// <summary>
        /// Este método se encarga de crear la nueva reparación y agregarla al repositorio
        /// </summary>
        /// <param name="pProblema">El problema de la nueva reparación</param>
        /// <param name="pFechaIngreso">La fecha de ingreso de la nueva reparación</param>
        /// <param name="pContraseña">La contraseña del dispositivo de la nueva reparación</param>
        /// <param name="pCargador">Si el dispositivo de la nueva reparación incluye cargador o no</param>
        /// <param name="pCables">Si el dispositivo de la nueva reparación incluye cables o no</param>
        /// <param name="pCliente">El ID del cliente asociado a la nueva reparación</param>
        /// <param name="pTipoEquipo">El tipo del equipo correspondiente a la nueva reparación</param>
        /// <param name="pMarcaEquipo">La marca del equipo correspondiente a la nueva reparación</param>
        public void AgregarReparacion(string pProblema, DateTime pFechaIngreso, DateTime pFechaReparacion, string pContraseña, bool pCargador, bool pCables, int pCliente, int pTipoEquipo, int pMarcaEquipo, bool pReparado)
        {
            Reparacion reparacion = new Reparacion();
            reparacion.Problema = pProblema;
            reparacion.FechaIngreso = pFechaIngreso;
            if (pReparado)
            {
                reparacion.FechaReparacion = pFechaReparacion;
            }
            reparacion.Contraseña = pContraseña;
            reparacion.Cargador = pCargador;
            reparacion.Cables = pCables;
            reparacion.Entregado = false;
            reparacion.LineasReparacion = new List<LineaReparacion>();
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Cliente cliente = bUoW.RepositorioCliente.Obtener(pCliente);
                    reparacion.Cliente = cliente;
                    Marca marca = bUoW.RepositorioMarca.Obtener(pMarcaEquipo);
                    reparacion.Marca = marca;
                    Rubro tipo = bUoW.RepositorioRubro.Obtener(pTipoEquipo);
                    reparacion.Rubro = tipo;
                    bUoW.RepositorioReparacion.Agregar(reparacion);
                    bUoW.GuardarCambios();
                }
            }
        }

        /// <summary>
        /// Este método se encarga de devolver una lista de todas las reparaciones presentes
        /// en el repositorio, según distintos filtros
        /// </summary>
        /// <param name="fueReparada">Si las reparaciones listadas incluyen a las reparadas o no</param>
        /// <param name="fueEntregada">Si las reparaciones listadas incluyen a las entregadas o no</param>
        /// <param name="fueCobrada">Si las reparaciones listadas incluyen a las pagas o no</param>
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
        /// <param name="idReparacion">El ID de la reparación a modificar</param>
        public void ModificarReparacion(string pProblema, string pContraseña, bool pCargador, bool pCables, string pSolucion, DateTime pFechaReparacion, float pPrecio, bool pEntregado, List<LineaReparacion> pProductosUtilizados, int idReparacion, int pMetodoPago = 0)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Reparacion reparacion = bUoW.RepositorioReparacion.Obtener(idReparacion);
                    reparacion.Problema = pProblema;
                    reparacion.Contraseña = pContraseña;
                    reparacion.Cargador = pCargador;
                    reparacion.Cables = pCables;
                    reparacion.Solucion = pSolucion;
                    reparacion.FechaReparacion = pFechaReparacion;
                    reparacion.Precio = pPrecio;
                    reparacion.Entregado = pEntregado;
                    if (pMetodoPago != 0)
                    {
                        MetodoPago metodoPago = bUoW.RepositorioMetodoPago.Obtener(pMetodoPago);
                        reparacion.MetodoPago = metodoPago;
                    }
                    reparacion.LineasReparacion = pProductosUtilizados;
                    bUoW.GuardarCambios();
                }
            }
        }

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
    }
}