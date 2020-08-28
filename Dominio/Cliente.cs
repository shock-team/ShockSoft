using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Dominio
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string iDNI { get; set; }
        public string iCUIT { get; set; }
        public string iApellido { get; set; }
        public string iNombre { get; set; }
        public string iTelefono { get; set; }
        public string iDireccion { get; set; }
        public Localidad iLocalidad { get; set; }
    }
}
