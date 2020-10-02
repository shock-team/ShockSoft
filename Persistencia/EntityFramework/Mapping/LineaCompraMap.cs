using ShockSoft.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace ShockSoft.Persistencia.EntityFramework.Mapping
{
    class LineaCompraMap : EntityTypeConfiguration<LineaCompra>
    {
        public LineaCompraMap()
        {
            this.ToTable("LineasDeCompras");

            this.HasKey(x => new
            {
                x.IdLineaCompra,
                x.IdCompra
            });

            this.Property(x => x.IdLineaCompra)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Cantidad)
                .HasColumnName("cantidad")
                .IsRequired();

            this.Property(x => x.PrecioActual)
                .HasColumnName("precioActual")
                .IsRequired();
        }
    }
}
