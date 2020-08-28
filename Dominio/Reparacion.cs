using System;

namespace ShockSoft.Dominio
{
	class Reparacion
	{
        public int id { get; set; }
        public string iProblema { get; set; }
        public string iSolucion { get; set; }
        public string iContraseña { get; set; }
        public DateTime iFechaIngreso { get; set; }
        public DateTime iFechaReparacion { get; set; }
        public float iPrecio { get; set; }
        public bool iEntregado { get; set; }
        public bool iCargador { get; set; }
        public bool iCables { get; set; }

    }
}
