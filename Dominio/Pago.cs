﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Dominio
{
    public class Pago
    {
        public int IdPago { get; set; }
        public DateTime Fecha { get; set; }
        public float Monto { get; set; }
    }
}
