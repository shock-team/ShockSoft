﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Dominio
{
    public class LineaVenta
    {
        public int Cantidad { get; set; }
        public float PrecioActual { get; set; }
        public Producto Producto { get; set; }
    }
}
