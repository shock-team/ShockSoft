﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Excepciones
{
    [Serializable]
    class DatosRepetidosException : Exception
    {
        public DatosRepetidosException() : base("Los datos están repetidos") { }
    }
}
