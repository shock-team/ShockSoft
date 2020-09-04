using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShockSoft.Dominio;

namespace ShockSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase Marca
    /// y las clases de dominio
    /// </summary>
    public class ControladorMarcas
    {
        /// <summary>
        /// Este método se encarga de crear la nueva marca y agregarla al repositorio
        /// </summary>
        /// <param name="pDescripcion">La descripción de la nueva marca</param>
        public void AgregarMarca(string pDescripcion)
        {
            Marca marca = new Marca();
            marca.Descripcion = pDescripcion;
        }

        /// <summary>
        /// Este método se encarga de devolver una lista de todas las marcas presentes
        /// en el repositorio
        /// </summary>
        /// <returns></returns>
        public List<Marca> ListarMarcas()
        {
            List<Marca> listaMarcas = new List<Marca>();
            return listaMarcas;
        }

        /// <summary>
        /// Este método se encarga de modificar los datos de una marca existente
        /// en el repositorio
        /// </summary>
        /// <param name="pDescripcion">La nueva descripción de la marca</param>
        /// <param name="idMarca">El ID de la marca a modificar</param>
        public void ModificarMarca(string pDescripcion, int idMarca)
        {
            Marca marca = new Marca();
            marca.Descripcion = pDescripcion;
        }
    }
}
