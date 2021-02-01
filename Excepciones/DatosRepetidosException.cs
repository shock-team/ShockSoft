using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZonaSoft.Excepciones
{
    [Serializable]
    class DatosRepetidosException : Exception
    {
        public DatosRepetidosException() : base() { }

        public DatosRepetidosException(string message) :
            base(String.Format("Los siguientes datos ya existen: {0}", message))
        { }
    }
}
