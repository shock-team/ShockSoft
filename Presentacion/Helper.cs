using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Presentacion
{
    public static class Helper
    {
        public static string NameFormatter(string pNombre ,string pApellido)
        {
            return String.Format("{0}, {1}", pNombre, pApellido);
        }
    }
}
