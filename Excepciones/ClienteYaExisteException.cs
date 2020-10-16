using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Excepciones
{
    class ClienteYaExisteException : Exception
    {
        public ClienteYaExisteException() : base("Ya existe un cliente con ese DNI o CUIT") { }
    }
}
