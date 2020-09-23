using System.Collections.Generic;

namespace ShockSoft.Dominio
{
    public class Parametro
    {
        //Atributos
        public int IdParametro { get; set; }
        public string Descripcion { get; set; }
        public float Valor { get; set; }

        //FluentAPI
        public ICollection<Producto> Productos { get; set; }
    }
}
