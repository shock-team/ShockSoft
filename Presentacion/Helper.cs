using System;

namespace ShockSoft.Presentacion
{
    public static class Helper
    {
        public static string NameFormatter(string pNombre, string pApellido)
        {
            return String.Format("{0}, {1}", pApellido, pNombre);
        }
    }
}
