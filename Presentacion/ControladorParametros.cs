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
    /// GUI correspondiente a los casos de uso asociados a la clase Parametro
    /// y las clases de dominio
    /// </summary>
    public class ControladorParametros
    {
        /// <summary>
        /// Este método se encarga de crear el nuevo parámetro y almacenarlo
        /// en el repositorio
        /// </summary>
        /// <param name="pDescripcion">La descripción del nuevo parámetro</param>
        /// <param name="pValor">El valor del nuevo parámetro</param>
        public void AgregarParametro(string pDescripcion, float pValor)
        {
            Parametro parametro = new Parametro();
            parametro.Descripcion = pDescripcion;
            parametro.Valor = pValor;
        }

        /// <summary>
        /// Este método se encarga de devolver una lista de todos los
        /// parámetros presentes en el repositorio
        /// </summary>
        /// <returns></returns>
        public List<Parametro> ListarParametros()
        {
            List<Parametro> listaParametros = new List<Parametro>();
            return listaParametros;
        }

        /// <summary>
        /// Este método se encarga de modificar los datos de un parámetro existente
        /// en el repositorio
        /// </summary>
        /// <param name="pDescripcion">La nueva descripción del parámetro</param>
        /// <param name="pValor">El nuevo valor del parámetro</param>
        /// <param name="idParametro">El ID del parámetro a modificar</param>
        public void ModificarParametro(string pDescripcion, float pValor, int idParametro)
        {

        }
    }
}
