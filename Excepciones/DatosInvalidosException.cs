using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Excepciones
{
    [Serializable]
    class DatosInvalidosException : Exception
    {
        public DatosInvalidosException() : base() { }

        public DatosInvalidosException(string message) : 
            base(String.Format("Los datos ingresados son inválidos: {0}", message)) { }
    }
}
