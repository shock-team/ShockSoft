using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShockSoft.Dominio;

namespace ShockSoft.Presentacion
{
    public class ControladorLocalidades
    {
        public void AgregarLocalidad(string pNombre)
        {
            Localidad localidad = new Localidad();
            localidad.Nombre = pNombre;
        }

        public List<Localidad> ListarLocalidades()
        {
            List<Localidad> listaLocalidades = new List<Localidad>();
            return listaLocalidades;
        }

        public void ModificarLocalidad(Localidad pLocalidad)
        {

        }
    }
}
