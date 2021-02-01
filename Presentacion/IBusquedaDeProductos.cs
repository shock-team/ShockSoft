using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZonaSoft.Presentacion
{
    interface IBusquedaDeProductos
    {
        void AgregarProducto(int pIdProducto, int pCantidad = 0);
    }
}
