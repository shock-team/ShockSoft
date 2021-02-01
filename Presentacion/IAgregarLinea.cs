using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZonaSoft.Presentacion
{
    interface IAgregarLinea
    {
        void AgregarLinea(string pIdProducto, string pDescripcion, string pPrecioActual, int pCantidad);
    }
}
