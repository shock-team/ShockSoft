using ShockSoft.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace ShockSoft.Persistencia.EntityFramework.Mapping
{
    class ProveedorMap : EntityTypeConfiguration<Proveedor>
    {
        public ProveedorMap()
        {
            this.ToTable("Proveedores");

            this.HasKey(x => x.IdProveedor);

            this.Property(x => x.IdProveedor)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Nombre)
                .HasColumnName("nombre")
                .IsRequired();
        }
    }
}
