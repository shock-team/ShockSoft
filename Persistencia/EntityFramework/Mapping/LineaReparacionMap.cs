using ShockSoft.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Persistencia.EntityFramework.Mapping
{
    class LineaReparacionMap : EntityTypeConfiguration<LineaReparacion>
    {
        public LineaReparacionMap()
        {
            this.ToTable("LineasDeReparaciones");

            this.HasKey(x => new
            {
                x.IdLineaReparacion,
                x.IdReparacion
            });

            this.Property(x => x.IdLineaReparacion)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.IdProducto)
                .HasColumnName("idProducto")
                .IsRequired();

            this.Property(x => x.Cantidad)
                .HasColumnName("cantidad")
                .IsRequired();

            this.Property(x => x.PrecioActual)
                .HasColumnName("precioActual")
                .IsRequired();

            this.HasRequired<Producto>(x => x.Producto)
                .WithMany(x => x.LineasReparaciones)
                .HasForeignKey<int>(x => x.IdProducto);
        }
    }  
}
