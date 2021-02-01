using ZonaSoft.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace ZonaSoft.Persistencia.EntityFramework.Mapping
{
    class LineaVentaMap : EntityTypeConfiguration<LineaVenta>
    {
        public LineaVentaMap()
        {
            this.ToTable("LineasDeVentas");

            this.HasKey(x => new
            {
                x.IdLineaVenta,
                x.IdVenta
            });

            this.Property(x => x.IdLineaVenta)
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
                .WithMany(x => x.LineasVenta)
                .HasForeignKey<int>(x => x.IdProducto);
        }
    }
}
