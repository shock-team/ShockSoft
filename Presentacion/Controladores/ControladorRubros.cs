﻿using ZonaSoft.Dominio;
using ZonaSoft.Persistencia.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace ZonaSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase TipoEquipo
    /// y las clases de dominio. Esta clase aplica el patrón de diseño Singleton.
    /// </summary>
    public class ControladorRubros
    {
        private static ControladorRubros _instancia;

        /// <summary>
        /// Obtiene la instancia del controlador
        /// </summary>
        /// <returns></returns>
        public static ControladorRubros ObtenerInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladorRubros();
            }

            return _instancia;
        }

        /// <summary>
        /// Este método se encarga de crear el nuevo rubro y agregarlo al repositorio
        /// </summary>
        /// <param name="pDescripcion">La descripción del nuevo rubro</param>
        public void AgregarRubro(string pDescripcion)
        {
            Rubro rubro = new Rubro();
            rubro.Descripcion = pDescripcion;
            using (var pDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(pDbContext))
                {
                    bUoW.RepositorioRubro.Agregar(rubro);
                    bUoW.GuardarCambios();
                }
            }
        }

        /// <summary>
        /// Este método se encarga de devolver una lista de todos los rubros
        /// presentes en el repositorio.
        /// </summary>
        /// <returns></returns>
        public List<Rubro> ListarRubros()
        {
            List<Rubro> listaRubros;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    listaRubros = bUoW.RepositorioRubro.ObtenerTodos().ToList();
                }
            }
            return listaRubros;
        }

        /// <summary>
        /// Este método se encarga de devolver una lista un rango de rubros
        /// presentes en el repositorio.
        /// </summary>
        /// <param name="pDesde">El índice a partir del cual obtener los rubros.</param>
        /// <param name="pCantidad">La cantidad de rubros a devolver.</param>
        /// <returns></returns>
        public List<Rubro> ListarRubros(int pDesde, int pCantidad)
        {
            List<Rubro> listaRubros;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    listaRubros = bUoW.RepositorioRubro.ObtenerRubros(pDesde, pCantidad).ToList();
                }
            }
            return listaRubros;
        }

        /// <summary>
        /// Este método se encarga de modificar los datos de un rubro existente
        /// en el repositorio
        /// </summary>
        /// <param name="pDescripcion">La nueva descripción del rubro</param>
        /// <param name="IdRubro">El ID del rubro a modificar</param>
        public void ModificarRubro(int IdRubro, string pDescripcion)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Rubro tipoAModificar = bUoW.RepositorioRubro.Obtener(IdRubro);
                    tipoAModificar.Descripcion = pDescripcion;
                    bUoW.GuardarCambios();
                }
            }
        }

        /// <summary>
        /// Este método se utiliza para obtener la cantidad de rubros presentes en la base de datos.
        /// </summary>
        /// <returns></returns>
        public int ObtenerCantidadDeRubros()
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    return bUoW.RepositorioRubro.CantidadFilas();
                }
            }
        }
    }
}
