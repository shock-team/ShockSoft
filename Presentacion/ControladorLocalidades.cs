using ShockSoft.Dominio;
using System.Collections.Generic;

namespace ShockSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase Localidad
    /// y las clases de dominio
    /// </summary>
    public class ControladorLocalidades
    {
        /// <summary>
        /// Este método se encarga de crear la nueva localidad y agregarla al repositorio
        /// </summary>
        /// <param name="pNombre">El nombre de la nueva localidad</param>
        public void AgregarLocalidad(string pNombre)
        {
            Localidad localidad = new Localidad();
            localidad.Nombre = pNombre;
        }

        /// <summary>
        /// Este método se encarga de devolver una lista de todas las localidades
        /// presentes en el repositorio
        /// </summary>
        /// <returns></returns>
        public List<Localidad> ListarLocalidades()
        {
            List<Localidad> listaLocalidades = new List<Localidad>();
            return listaLocalidades;
        }

        /// <summary>
        /// Este método se encarga de modificar los datos de una localidad existente
        /// en el repositorio
        /// </summary>
        /// <param name="pNombre">El nuevo nombre de la localidad</param>
        /// <param name="idLocalidad">El ID de la localidad a modificar</param>
        public void ModificarLocalidad(string pNombre, int idLocalidad)
        {

        }
    }
}
