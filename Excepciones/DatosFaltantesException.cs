using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Excepciones
{
    [Serializable]
    class DatosFaltantesException : Exception
    {
        public DatosFaltantesException() : base() { }

        public DatosFaltantesException(string message) :
            base(String.Format("Ingrese por favor los datos faltantes: {0}", message))
        { }
    }
}
