﻿using ShockSoft.Dominio;
using ShockSoft.Persistencia.EntityFramework;
using System.Collections.Generic;

namespace ShockSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase TipoEquipo
    /// y las clases de dominio. Esta clase aplica el patrón de diseño Singleton.
    /// </summary>
    class ControladorTiposDeEquipo
    {
        public static ControladorTiposDeEquipo instancia;

        /// <summary>
        /// Obtiene la instancia del controlador
        /// </summary>
        /// <returns></returns>
        public static ControladorTiposDeEquipo ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ControladorTiposDeEquipo();
            }
            return instancia;
        }

        /// <summary>
        /// Este método se encarga de crear el nuevo tipo de equipo y agregarlo al repositorio
        /// </summary>
        /// <param name="pDescripcion">La descripción del nuevo tipo de equipo</param>
        public void AgregarTipoDeEquipo(string pDescripcion)
        {
            TipoEquipo tipo = new TipoEquipo();
            tipo.Descripcion = pDescripcion;
            using (var pDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(pDbContext))
                {
                    bUoW.RepositorioTipoEquipo.Agregar(tipo);
                    bUoW.GuardarCambios();
                }
            }
        }

        /// <summary>
        /// Este método se encarga de devolver una lista de todos los tipos
        /// de equipo presentes en el repositorio.
        /// </summary>
        /// <returns></returns>
        public List<TipoEquipo> ListarTiposDeEquipo()
        {
            List<TipoEquipo> listaTipos = new List<TipoEquipo>();
            return listaTipos;
        }

        /// <summary>
        /// Este método se encarga de modificar los datos de un tipo de equipo existente
        /// en el repositorio
        /// </summary>
        /// <param name="pDescripcion">La nueva descripción del tipo de equipo</param>
        /// <param name="idTipoEquipo">El ID del tipo de equipo a modificar</param>
        public void ModificarTipoDeEquipo(string pDescripcion, int idTipoEquipo)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    TipoEquipo tipoAModificar = bUoW.RepositorioTipoEquipo.Obtener(idTipoEquipo);
                    tipoAModificar.Descripcion = pDescripcion;
                    bUoW.GuardarCambios();
                }
            }
        }
    }
}