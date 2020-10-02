using ShockSoft.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace ShockSoft.Persistencia.EntityFramework.Mapping
{
    class VentaMap : EntityTypeConfiguration<Venta>
    {
        public VentaMap()
        {
            this.ToTable("Ventas");

            this.HasKey(x => x.IdVenta);
            this.Property(x => x.IdVenta)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Fecha)
                .HasColumnName("fecha")
                .IsRequired();

            this.HasRequired<Cliente>(x => x.Cliente)
                .WithMany(x => x.Ventas)
                .HasForeignKey<int>(x => x.IdCliente);

            this.HasRequired<MetodoPago>(x => x.MetodoPago)
                .WithMany(x => x.Ventas)
                .HasForeignKey<int>(x => x.IdMetodoPago);

            this.HasMany(x => x.Lineas)
                .WithRequired(x => x.Venta)
                .HasForeignKey(x => x.IdVenta);
        }
    }
}
