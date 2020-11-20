using ShockSoft.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace ShockSoft.Persistencia.EntityFramework.Mapping
{
    class CompraMap : EntityTypeConfiguration<Compra>
    {
        public CompraMap()
        {
            this.ToTable("Compras");

            this.HasKey(x => x.IdCompra);
            this.Property(x => x.IdCompra)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Fecha)
                .HasColumnName("fecha")
                .IsRequired();

            this.Property(x => x.CostoTotalPesos)
                .HasColumnName("costoTotalPesos");

            this.Property(x => x.DolarProveedor)
                .HasColumnName("dolarProveedor");

            this.HasRequired<Proveedor>(x => x.Proveedor)
                .WithMany(x => x.Compras)
                .HasForeignKey<int>(x => x.IdProveedor);

            this.HasMany(x => x.LineasCompra)
                .WithRequired(x => x.Compra)
                .HasForeignKey(x => x.IdCompra);
        }
    }
}
